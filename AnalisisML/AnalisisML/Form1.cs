/* Software para hacer análisis de series temporales
 * Autor: Rafael Alberto Moreno Parra
 * Fecha: 24 de septiembre de 2025
 * Universidad Libre - Cali
 * Correo: rafael-morenop@unilibre.edu.co
 * Proyecto: ECOSISTEMA DE ARQUITECTURAS DIGITALES PARA SOLUCIONES BASADAS EN INTELIGENCIA 
 ARTIFICIAL */

using Microsoft.ML;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnalisisML
{
    public partial class Form1 : Form {
        PredictionEngine<ModeloDatos, ModeloPrediccion> MotorPrediccion;

        public Form1() {
            InitializeComponent();
        }

        private void mnuAbrir_Click(object sender, EventArgs e) {
            if (dlgArchivo.ShowDialog() == DialogResult.OK) {
                txtURLDatos.Text = dlgArchivo.FileName;
                btnCarga.Enabled = true;
            }
        }

        private void btnCarga_Click(object sender, EventArgs e) {
            // Leer el archivo CSV manualmente y convertirlo a List<ModeloDatos>
            var ListaDatos = File.ReadAllLines(txtURLDatos.Text)
                .Skip(1) // omitir encabezado
                .Select(linea => {
                    var partes = linea.Split(',');
                    return new ModeloDatos {
                        Entrada = float.Parse(partes[0], CultureInfo.InvariantCulture),
                        Salida = float.Parse(partes[1], CultureInfo.InvariantCulture)
                    };
                })
                .GroupBy(d => d.Entrada) // agrupar por Columna1
                .Select(g => new ModeloDatos {
                    Entrada = g.Key,
                    Salida = g.Average(x => x.Salida) // promedio de Columna2
                })
                .OrderBy(d => d.Entrada) // ordenar por Columna1
                .ToList();

            //Mínimo deben haber 100 registros para poder hacer predicciones
            if (ListaDatos.Count < 100) {
                MessageBox.Show("Mínimo son cien(100) registros para poder hacer predicciones. El archivo de datos no tiene esa cantidad mínima.", "Error. Muy pocos registros.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Habilita los botones
            btnPredecir.Enabled = true;

            // Convertir el List<ModeloDatos> a IDataView
            MLContext ContextoML = new MLContext();
            IDataView Datos = ContextoML.Data.LoadFromEnumerable(ListaDatos);

            // Dividir los datos en entrenamiento y testeo
            var PreparaDatos = ContextoML.Data.TrainTestSplit(Datos, testFraction: 0.2);
            var DatosEntrenamiento = PreparaDatos.TrainSet;
            var DatosTesteo = PreparaDatos.TestSet;

            // Definir el pipeline de entrenamiento (aprendizaje) con
            // normalización y ajuste de parámetros.
            //Fue necesario instalar el paquete Microsoft.ML.FastTree
            var Aprendizaje = ContextoML.Transforms.Concatenate("Caracteristicas", "Entrada")
                .Append(ContextoML.Transforms.NormalizeMinMax("Caracteristicas"))
                .Append(ContextoML.Regression.Trainers.FastTree(labelColumnName: "Salida", featureColumnName: "Caracteristicas", numberOfLeaves: 20, minimumExampleCountPerLeaf: 10));

            // Entrenar el modelo
            var ModeloEntrenado = Aprendizaje.Fit(DatosEntrenamiento);

            // Hacer predicciones
            var Predicciones = ModeloEntrenado.Transform(DatosTesteo);
            var Metricas = ContextoML.Regression.Evaluate(Predicciones, labelColumnName: "Salida");

            // Imprimir métricas de evaluación
            txtCoeficiente.Text = Metricas.RSquared.ToString();

            /*
			 * En ML.NET, Mean Absolute Error (MAE) es una métrica
			 * utilizada para evaluar la precisión de un modelo de
			 * regresión. MAE mide la media de los errores absolutos
			 * entre las predicciones del modelo y los valores reales.
			 * En otras palabras, calcula la distancia promedio entre
			 * las predicciones y los valores verdaderos, sin
			 * considerar la dirección del error (es decir, si es
			 * positivo o negativo).
			 * Un valor de MAE más bajo indica un modelo más preciso,
			 * ya que los errores promedio son menores.
			 * */
txtPrecision.Text = Metricas.MeanAbsoluteError.ToString();

            /*
			 * En ML.NET, Mean Squared Error (MSE) es una métrica
			 * utilizada para evaluar la precisión de un modelo de
			 * regresión. MSE mide el promedio de los cuadrados de
			 * los errores, es decir, la diferencia entre los
			 * valores predichos por el modelo y los valores reales.
			 * Esta métrica penaliza los errores grandes más que
			 * los pequeños, ya que los errores se elevan al cuadrado
			 * antes de promediarse. */
            txtPromedio.Text = Metricas.MeanSquaredError.ToString();

            // GRÁFICO LINEAL
            // Limpiar configuración previa
            chtGrafico.Series.Clear();
            chtGrafico.ChartAreas.Clear();
            chtGrafico.Titles.Clear();
            chtGrafico.Legends.Clear();

            // Crear área de gráfico
            ChartArea area = new ChartArea("MainArea");
            chtGrafico.ChartAreas.Add(area);

            // Crear leyenda
            Legend leyenda = new Legend("Leyenda");
            chtGrafico.Legends.Add(leyenda);

            // Crear series
            Series serieA = new Series("Dato Real");
            serieA.ChartType = SeriesChartType.Line;
            serieA.ChartArea = "MainArea";
            serieA.Legend = "Leyenda";

            Series serieB = new Series("Predicción ML .NET");
            serieB.ChartType = SeriesChartType.Line;
            serieB.ChartArea = "MainArea";
            serieB.Legend = "Leyenda";

            chtGrafico.Series.Add(serieA);
            chtGrafico.Series.Add(serieB);

            chtGrafico.Titles.Add("Serie Temporal: Dato real vs Predicción por ML .NET");

            // Etiqueta para el eje X
            chtGrafico.ChartAreas[0].AxisX.Title = "Tiempo";
            chtGrafico.ChartAreas[0].AxisX.TitleFont = new Font("Verdana", 12, FontStyle.Bold);

            // Etiqueta para el eje Y
            chtGrafico.ChartAreas[0].AxisY.Title = "Valor";
            chtGrafico.ChartAreas[0].AxisY.TitleFont = new Font("Verdana", 12, FontStyle.Bold);

            // Crear un motor de predicción
            MotorPrediccion = ContextoML.Model.CreatePredictionEngine<ModeloDatos, ModeloPrediccion>(ModeloEntrenado);

            // Predicciones
            dgvPredice.Rows.Clear();
            foreach (var Fila in ListaDatos) {
                ModeloPrediccion predice = MotorPrediccion.Predict(new ModeloDatos { Entrada = Fila.Entrada });
                dgvPredice.Rows.Add(Fila.Entrada, Fila.Salida, predice.SalidaML);

                serieA.Points.AddXY(Fila.Entrada, Fila.Salida);
                serieB.Points.AddXY(Fila.Entrada, predice.SalidaML);
            }

            //Los tiempos iniciales y finales
            numTiempoInicial.Value = (decimal)ListaDatos[0].Entrada;
            numTiempoFinal.Value = (decimal)ListaDatos[ListaDatos.Count - 1].Entrada;
        }

        private void btnPredecir_Click(object sender, EventArgs e) {
            float Tiempo = (float) numTiempo.Value;
            float TiempoInicial = (float)numTiempoInicial.Value;
            float TiempoFinal = (float)numTiempoFinal.Value;

            if (Tiempo >= TiempoInicial && Tiempo <= TiempoFinal)
                lblValorPredice.Text = "Valor por interpolación";
            else
                lblValorPredice.Text = "¡OJO! Valor por EXTRAPOLACIÓN";

            ModeloPrediccion predice = MotorPrediccion.Predict(new ModeloDatos { Entrada = Tiempo });
            numValor.Value = (decimal)predice.SalidaML;
        }
    }
}
