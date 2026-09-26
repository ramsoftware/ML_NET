/* Software para hacer análisis de series temporales
 * Autor: Rafael Alberto Moreno Parra
 * Fecha: 24 de septiembre de 2025
 * Universidad Libre - Cali
 * Correo: rafael-morenop@unilibre.edu.co
 * Proyecto: ECOSISTEMA DE ARQUITECTURAS DIGITALES PARA SOLUCIONES BASADAS EN INTELIGENCIA 
 ARTIFICIAL */

using Microsoft.ML.Data;

namespace AnalisisML {
    internal class ModeloPrediccion {
        [ColumnName("Score")]
        public float SalidaML { get; set; }
    }
}
