namespace AnalisisML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mnuMenu = new MenuStrip();
            mnuArchivo = new ToolStripMenuItem();
            mnuAbrir = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuSalir = new ToolStripMenuItem();
            mnuAyuda = new ToolStripMenuItem();
            mnuAcerca = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabDatos = new TabPage();
            txtPromedio = new TextBox();
            txtURLDatos = new TextBox();
            txtPrecision = new TextBox();
            btnCarga = new Button();
            txtCoeficiente = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabTabla = new TabPage();
            dgvPredice = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Prediccion = new DataGridViewTextBoxColumn();
            tabGrafico = new TabPage();
            chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPrediccion = new TabPage();
            numTiempoFinal = new NumericUpDown();
            numTiempoInicial = new NumericUpDown();
            lblTiempoFinal = new Label();
            lblTiempoInicial = new Label();
            btnPredecir = new Button();
            numValor = new NumericUpDown();
            lblValorPredice = new Label();
            numTiempo = new NumericUpDown();
            label5 = new Label();
            lblExplica = new Label();
            dlgArchivo = new OpenFileDialog();
            mnuMenu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDatos.SuspendLayout();
            tabTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPredice).BeginInit();
            tabGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtGrafico).BeginInit();
            tabPrediccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTiempoFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTiempoInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTiempo).BeginInit();
            SuspendLayout();
            // 
            // mnuMenu
            // 
            mnuMenu.Items.AddRange(new ToolStripItem[] { mnuArchivo, mnuAyuda });
            mnuMenu.Location = new Point(0, 0);
            mnuMenu.Name = "mnuMenu";
            mnuMenu.Padding = new Padding(7, 2, 0, 2);
            mnuMenu.Size = new Size(914, 24);
            mnuMenu.TabIndex = 0;
            mnuMenu.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnuAbrir, toolStripMenuItem1, mnuSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(60, 20);
            mnuArchivo.Text = "&Archivo";
            // 
            // mnuAbrir
            // 
            mnuAbrir.Name = "mnuAbrir";
            mnuAbrir.Size = new Size(199, 22);
            mnuAbrir.Text = "Abrir archivo de datos...";
            mnuAbrir.Click += mnuAbrir_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(196, 6);
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(199, 22);
            mnuSalir.Text = "Salir";
            // 
            // mnuAyuda
            // 
            mnuAyuda.DropDownItems.AddRange(new ToolStripItem[] { mnuAcerca });
            mnuAyuda.Name = "mnuAyuda";
            mnuAyuda.Size = new Size(53, 20);
            mnuAyuda.Text = "A&yuda";
            // 
            // mnuAcerca
            // 
            mnuAcerca.Name = "mnuAcerca";
            mnuAcerca.Size = new Size(135, 22);
            mnuAcerca.Text = "Acerca de...";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDatos);
            tabControl1.Controls.Add(tabTabla);
            tabControl1.Controls.Add(tabGrafico);
            tabControl1.Controls.Add(tabPrediccion);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 646);
            tabControl1.TabIndex = 1;
            // 
            // tabDatos
            // 
            tabDatos.Controls.Add(txtPromedio);
            tabDatos.Controls.Add(txtURLDatos);
            tabDatos.Controls.Add(txtPrecision);
            tabDatos.Controls.Add(btnCarga);
            tabDatos.Controls.Add(txtCoeficiente);
            tabDatos.Controls.Add(label4);
            tabDatos.Controls.Add(label2);
            tabDatos.Controls.Add(label3);
            tabDatos.Location = new Point(4, 25);
            tabDatos.Margin = new Padding(3, 4, 3, 4);
            tabDatos.Name = "tabDatos";
            tabDatos.Padding = new Padding(3, 4, 3, 4);
            tabDatos.Size = new Size(906, 617);
            tabDatos.TabIndex = 0;
            tabDatos.Text = "Datos";
            tabDatos.UseVisualStyleBackColor = true;
            // 
            // txtPromedio
            // 
            txtPromedio.BackColor = Color.MistyRose;
            txtPromedio.Location = new Point(423, 496);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(263, 23);
            txtPromedio.TabIndex = 18;
            txtPromedio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtURLDatos
            // 
            txtURLDatos.Location = new Point(8, 19);
            txtURLDatos.Name = "txtURLDatos";
            txtURLDatos.ReadOnly = true;
            txtURLDatos.Size = new Size(890, 23);
            txtURLDatos.TabIndex = 17;
            // 
            // txtPrecision
            // 
            txtPrecision.BackColor = Color.Silver;
            txtPrecision.Location = new Point(423, 249);
            txtPrecision.Name = "txtPrecision";
            txtPrecision.ReadOnly = true;
            txtPrecision.Size = new Size(263, 23);
            txtPrecision.TabIndex = 17;
            txtPrecision.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCarga
            // 
            btnCarga.Enabled = false;
            btnCarga.Location = new Point(8, 48);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(890, 46);
            btnCarga.TabIndex = 2;
            btnCarga.Text = "Carga los datos del archivo y los procesa";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.BackColor = Color.Moccasin;
            txtCoeficiente.Location = new Point(423, 100);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.ReadOnly = true;
            txtCoeficiente.Size = new Size(263, 23);
            txtCoeficiente.TabIndex = 16;
            txtCoeficiente.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Location = new Point(8, 419);
            label4.Name = "label4";
            label4.Size = new Size(372, 176);
            label4.TabIndex = 15;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Location = new Point(8, 100);
            label2.Name = "label2";
            label2.Size = new Size(231, 16);
            label2.TabIndex = 11;
            label2.Text = "Coeficiente de determinación R^2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(8, 153);
            label3.Name = "label3";
            label3.Size = new Size(366, 224);
            label3.TabIndex = 12;
            label3.Text = resources.GetString("label3.Text");
            // 
            // tabTabla
            // 
            tabTabla.Controls.Add(dgvPredice);
            tabTabla.Location = new Point(4, 25);
            tabTabla.Name = "tabTabla";
            tabTabla.Padding = new Padding(3);
            tabTabla.Size = new Size(906, 617);
            tabTabla.TabIndex = 3;
            tabTabla.Text = "Tabla";
            tabTabla.UseVisualStyleBackColor = true;
            // 
            // dgvPredice
            // 
            dgvPredice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPredice.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Prediccion });
            dgvPredice.Dock = DockStyle.Fill;
            dgvPredice.Location = new Point(3, 3);
            dgvPredice.Name = "dgvPredice";
            dgvPredice.Size = new Size(900, 611);
            dgvPredice.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tiempo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Valor";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Prediccion
            // 
            Prediccion.HeaderText = "Predicción";
            Prediccion.Name = "Prediccion";
            Prediccion.Width = 300;
            // 
            // tabGrafico
            // 
            tabGrafico.Controls.Add(chtGrafico);
            tabGrafico.Location = new Point(4, 25);
            tabGrafico.Name = "tabGrafico";
            tabGrafico.Padding = new Padding(3);
            tabGrafico.Size = new Size(906, 617);
            tabGrafico.TabIndex = 2;
            tabGrafico.Text = "Gráfico";
            tabGrafico.UseVisualStyleBackColor = true;
            // 
            // chtGrafico
            // 
            chartArea1.Name = "ChartArea1";
            chtGrafico.ChartAreas.Add(chartArea1);
            chtGrafico.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chtGrafico.Legends.Add(legend1);
            chtGrafico.Location = new Point(3, 3);
            chtGrafico.Name = "chtGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chtGrafico.Series.Add(series1);
            chtGrafico.Size = new Size(900, 611);
            chtGrafico.TabIndex = 0;
            chtGrafico.Text = "Datos Temporales y Predicción";
            // 
            // tabPrediccion
            // 
            tabPrediccion.Controls.Add(numTiempoFinal);
            tabPrediccion.Controls.Add(numTiempoInicial);
            tabPrediccion.Controls.Add(lblTiempoFinal);
            tabPrediccion.Controls.Add(lblTiempoInicial);
            tabPrediccion.Controls.Add(btnPredecir);
            tabPrediccion.Controls.Add(numValor);
            tabPrediccion.Controls.Add(lblValorPredice);
            tabPrediccion.Controls.Add(numTiempo);
            tabPrediccion.Controls.Add(label5);
            tabPrediccion.Controls.Add(lblExplica);
            tabPrediccion.Location = new Point(4, 25);
            tabPrediccion.Name = "tabPrediccion";
            tabPrediccion.Padding = new Padding(3);
            tabPrediccion.Size = new Size(906, 617);
            tabPrediccion.TabIndex = 4;
            tabPrediccion.Text = "Predicciones";
            tabPrediccion.UseVisualStyleBackColor = true;
            // 
            // numTiempoFinal
            // 
            numTiempoFinal.DecimalPlaces = 3;
            numTiempoFinal.Location = new Point(285, 218);
            numTiempoFinal.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numTiempoFinal.Minimum = new decimal(new int[] { 1569325055, 23283064, 0, int.MinValue });
            numTiempoFinal.Name = "numTiempoFinal";
            numTiempoFinal.ReadOnly = true;
            numTiempoFinal.Size = new Size(213, 23);
            numTiempoFinal.TabIndex = 9;
            numTiempoFinal.TextAlign = HorizontalAlignment.Right;
            // 
            // numTiempoInicial
            // 
            numTiempoInicial.DecimalPlaces = 3;
            numTiempoInicial.Location = new Point(285, 180);
            numTiempoInicial.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numTiempoInicial.Minimum = new decimal(new int[] { 1569325055, 23283064, 0, int.MinValue });
            numTiempoInicial.Name = "numTiempoInicial";
            numTiempoInicial.ReadOnly = true;
            numTiempoInicial.Size = new Size(213, 23);
            numTiempoInicial.TabIndex = 8;
            numTiempoInicial.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTiempoFinal
            // 
            lblTiempoFinal.AutoSize = true;
            lblTiempoFinal.Location = new Point(26, 220);
            lblTiempoFinal.Name = "lblTiempoFinal";
            lblTiempoFinal.Size = new Size(86, 16);
            lblTiempoFinal.TabIndex = 7;
            lblTiempoFinal.Text = "Tiempo final";
            // 
            // lblTiempoInicial
            // 
            lblTiempoInicial.AutoSize = true;
            lblTiempoInicial.Location = new Point(26, 180);
            lblTiempoInicial.Name = "lblTiempoInicial";
            lblTiempoInicial.Size = new Size(95, 16);
            lblTiempoInicial.TabIndex = 6;
            lblTiempoInicial.Text = "Tiempo inicial";
            // 
            // btnPredecir
            // 
            btnPredecir.Enabled = false;
            btnPredecir.Location = new Point(285, 302);
            btnPredecir.Name = "btnPredecir";
            btnPredecir.Size = new Size(261, 61);
            btnPredecir.TabIndex = 5;
            btnPredecir.Text = "Predecir";
            btnPredecir.UseVisualStyleBackColor = true;
            btnPredecir.Click += btnPredecir_Click;
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 5;
            numValor.Location = new Point(594, 340);
            numValor.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numValor.Minimum = new decimal(new int[] { 1569325055, 23283064, 0, int.MinValue });
            numValor.Name = "numValor";
            numValor.ReadOnly = true;
            numValor.Size = new Size(213, 23);
            numValor.TabIndex = 4;
            numValor.TextAlign = HorizontalAlignment.Right;
            // 
            // lblValorPredice
            // 
            lblValorPredice.AutoSize = true;
            lblValorPredice.Location = new Point(594, 309);
            lblValorPredice.Name = "lblValorPredice";
            lblValorPredice.Size = new Size(101, 16);
            lblValorPredice.TabIndex = 3;
            lblValorPredice.Text = "Valor obtenido";
            // 
            // numTiempo
            // 
            numTiempo.DecimalPlaces = 3;
            numTiempo.Location = new Point(26, 340);
            numTiempo.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numTiempo.Minimum = new decimal(new int[] { 1569325055, 23283064, 0, int.MinValue });
            numTiempo.Name = "numTiempo";
            numTiempo.Size = new Size(213, 23);
            numTiempo.TabIndex = 2;
            numTiempo.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 309);
            label5.Name = "label5";
            label5.Size = new Size(54, 16);
            label5.TabIndex = 1;
            label5.Text = "Tiempo";
            // 
            // lblExplica
            // 
            lblExplica.AutoSize = true;
            lblExplica.Location = new Point(20, 17);
            lblExplica.Name = "lblExplica";
            lblExplica.Size = new Size(602, 144);
            lblExplica.TabIndex = 0;
            lblExplica.Text = resources.GetString("lblExplica.Text");
            // 
            // dlgArchivo
            // 
            dlgArchivo.FileName = "openFileDialog1";
            dlgArchivo.Filter = "Archivos tipo dataset (*.csv)|*.csv";
            dlgArchivo.Title = "Abrir archivo de datos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 670);
            Controls.Add(tabControl1);
            Controls.Add(mnuMenu);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mnuMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uso de ML .NET  para análisis de series temporales";
            mnuMenu.ResumeLayout(false);
            mnuMenu.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabDatos.ResumeLayout(false);
            tabDatos.PerformLayout();
            tabTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPredice).EndInit();
            tabGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtGrafico).EndInit();
            tabPrediccion.ResumeLayout(false);
            tabPrediccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTiempoFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTiempoInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTiempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenu;
        private ToolStripMenuItem mnuArchivo;
        private ToolStripMenuItem mnuAbrir;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem mnuAyuda;
        private ToolStripMenuItem mnuAcerca;
        private TabControl tabControl1;
        private TabPage tabDatos;
        private Button btnCarga;
        private OpenFileDialog dlgArchivo;
        private TabPage tabGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private TabPage tabTabla;
        private DataGridView dgvPredice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Prediccion;
        private TextBox txtPromedio;
        private TextBox txtPrecision;
        private TextBox txtCoeficiente;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtURLDatos;
        private TabPage tabPrediccion;
        private Label lblExplica;
        private NumericUpDown numValor;
        private Label lblValorPredice;
        private NumericUpDown numTiempo;
        private Label label5;
        private Button btnPredecir;
        private NumericUpDown numTiempoFinal;
        private NumericUpDown numTiempoInicial;
        private Label lblTiempoFinal;
        private Label lblTiempoInicial;
    }
}
