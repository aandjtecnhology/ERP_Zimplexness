namespace SISTEMAFACTURACIONV1._0
{
    partial class ConsultaComprobantesControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxOtrosGastos = new System.Windows.Forms.TextBox();
            this.textBoxRetenciones = new System.Windows.Forms.TextBox();
            this.textBoxIIBB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalComprobantes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCuentaCorriente = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IIBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retenciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechainicio = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentaCorriente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 709);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.textBoxOtrosGastos);
            this.tabPage1.Controls.Add(this.textBoxRetenciones);
            this.tabPage1.Controls.Add(this.textBoxIIBB);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxIva);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxTotalComprobantes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dataGridViewCuentaCorriente);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comprobante por Proveedor y Periodo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "X Centros de Costos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(398, 478);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series2.Legend = "Legend1";
            series2.Name = "TotalComprobantes";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(216, 139);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            // 
            // textBoxOtrosGastos
            // 
            this.textBoxOtrosGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.textBoxOtrosGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOtrosGastos.Location = new System.Drawing.Point(120, 587);
            this.textBoxOtrosGastos.Multiline = true;
            this.textBoxOtrosGastos.Name = "textBoxOtrosGastos";
            this.textBoxOtrosGastos.Size = new System.Drawing.Size(100, 23);
            this.textBoxOtrosGastos.TabIndex = 37;
            // 
            // textBoxRetenciones
            // 
            this.textBoxRetenciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.textBoxRetenciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRetenciones.Location = new System.Drawing.Point(10, 588);
            this.textBoxRetenciones.Multiline = true;
            this.textBoxRetenciones.Name = "textBoxRetenciones";
            this.textBoxRetenciones.Size = new System.Drawing.Size(100, 23);
            this.textBoxRetenciones.TabIndex = 36;
            // 
            // textBoxIIBB
            // 
            this.textBoxIIBB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.textBoxIIBB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIIBB.Location = new System.Drawing.Point(118, 545);
            this.textBoxIIBB.Multiline = true;
            this.textBoxIIBB.Name = "textBoxIIBB";
            this.textBoxIIBB.Size = new System.Drawing.Size(100, 23);
            this.textBoxIIBB.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total Otros Gastos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total Retenciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total Ingresos Brutos";
            // 
            // textBoxIva
            // 
            this.textBoxIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.textBoxIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIva.Location = new System.Drawing.Point(11, 545);
            this.textBoxIva.Multiline = true;
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.Size = new System.Drawing.Size(100, 23);
            this.textBoxIva.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Iva Acumulado";
            // 
            // textBoxTotalComprobantes
            // 
            this.textBoxTotalComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxTotalComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalComprobantes.Location = new System.Drawing.Point(11, 503);
            this.textBoxTotalComprobantes.Multiline = true;
            this.textBoxTotalComprobantes.Name = "textBoxTotalComprobantes";
            this.textBoxTotalComprobantes.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotalComprobantes.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total de Comprobantes de Compras y Gastos";
            // 
            // dataGridViewCuentaCorriente
            // 
            this.dataGridViewCuentaCorriente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewCuentaCorriente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCuentaCorriente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCuentaCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentaCorriente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Proveedor,
            this.RazonSocial,
            this.TipoComprobante,
            this.TipoFactura,
            this.Sucursal,
            this.NoFactura,
            this.CondicionCompra,
            this.Total,
            this.IIBB,
            this.Retenciones,
            this.OtrosGastos,
            this.Iva,
            this.Estados});
            this.dataGridViewCuentaCorriente.Location = new System.Drawing.Point(5, 136);
            this.dataGridViewCuentaCorriente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridViewCuentaCorriente.Name = "dataGridViewCuentaCorriente";
            this.dataGridViewCuentaCorriente.Size = new System.Drawing.Size(968, 336);
            this.dataGridViewCuentaCorriente.TabIndex = 27;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            // 
            // TipoComprobante
            // 
            this.TipoComprobante.HeaderText = "Tipo de Comprobante";
            this.TipoComprobante.Name = "TipoComprobante";
            // 
            // TipoFactura
            // 
            this.TipoFactura.HeaderText = "Tipo de Factura";
            this.TipoFactura.Name = "TipoFactura";
            this.TipoFactura.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Punto V";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // NoFactura
            // 
            this.NoFactura.HeaderText = "No Factura";
            this.NoFactura.Name = "NoFactura";
            this.NoFactura.ReadOnly = true;
            // 
            // CondicionCompra
            // 
            this.CondicionCompra.HeaderText = "Condicion de Compra";
            this.CondicionCompra.Name = "CondicionCompra";
            this.CondicionCompra.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // IIBB
            // 
            this.IIBB.HeaderText = "Ingresos Brutos";
            this.IIBB.Name = "IIBB";
            // 
            // Retenciones
            // 
            this.Retenciones.HeaderText = "Retenciones";
            this.Retenciones.Name = "Retenciones";
            // 
            // OtrosGastos
            // 
            this.OtrosGastos.HeaderText = "Otros Gastos";
            this.OtrosGastos.Name = "OtrosGastos";
            // 
            // Iva
            // 
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            // 
            // Estados
            // 
            this.Estados.HeaderText = "Estados";
            this.Estados.Name = "Estados";
            this.Estados.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaFin);
            this.groupBox1.Controls.Add(this.dateTimePickerFechainicio);
            this.groupBox1.Controls.Add(this.checkBoxTodos);
            this.groupBox1.Controls.Add(this.comboBoxProveedor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(546, 124);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Busqueda";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources.if_document_print_118913;
            this.button3.Location = new System.Drawing.Point(500, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 43);
            this.button3.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button3, "Imprimir Comprobantes por fecha");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(157, 82);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(89, 21);
            this.dateTimePickerFechaFin.TabIndex = 12;
            // 
            // dateTimePickerFechainicio
            // 
            this.dateTimePickerFechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechainicio.Location = new System.Drawing.Point(12, 82);
            this.dateTimePickerFechainicio.Name = "dateTimePickerFechainicio";
            this.dateTimePickerFechainicio.Size = new System.Drawing.Size(89, 21);
            this.dateTimePickerFechainicio.TabIndex = 11;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(267, 39);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(158, 17);
            this.checkBoxTodos.TabIndex = 10;
            this.checkBoxTodos.Text = "Todos Los Proveedores";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.comboBoxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProveedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProveedor.ForeColor = System.Drawing.Color.White;
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(3, 36);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(230, 22);
            this.comboBoxProveedor.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1498842292_Citycons_magnify;
            this.button1.Location = new System.Drawing.Point(442, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button1, "Buscar Comprobantes");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Proveedor";
            // 
            // ConsultaComprobantesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Name = "ConsultaComprobantesControl";
            this.Size = new System.Drawing.Size(1018, 731);
            this.Load += new System.EventHandler(this.CuentaCorrienteControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentaCorriente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxOtrosGastos;
        private System.Windows.Forms.TextBox textBoxRetenciones;
        private System.Windows.Forms.TextBox textBoxIIBB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalComprobantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCuentaCorriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IIBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechainicio;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
