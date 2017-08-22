namespace SISTEMAFACTURACIONV1._0
{
    partial class PagoControl
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxConceptopago = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBanco = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNocheque = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMediopago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewComprobantesPendientes = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewMediosPago = new System.Windows.Forms.DataGridView();
            this.ColumnMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprobantesPendientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediosPago)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(385, 36);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Calcular";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textBox1.Location = new System.Drawing.Point(296, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 17);
            this.textBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Total Importe a Imputar";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Seleccionar Facturas a Imputar";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(280, 57);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Razon Social";
            // 
            // button3
            // 
            this.button3.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1498842292_Citycons_magnify;
            this.button3.Location = new System.Drawing.Point(215, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 36);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxConceptopago
            // 
            this.textBoxConceptopago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxConceptopago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConceptopago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textBoxConceptopago.Location = new System.Drawing.Point(698, 67);
            this.textBoxConceptopago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxConceptopago.Multiline = true;
            this.textBoxConceptopago.Name = "textBoxConceptopago";
            this.textBoxConceptopago.Size = new System.Drawing.Size(204, 56);
            this.textBoxConceptopago.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Banco";
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.comboBoxBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.Items.AddRange(new object[] {
            "Banco Patagonia",
            "Galicia",
            "ICBC",
            "Banco Credicoop"});
            this.comboBoxBanco.Location = new System.Drawing.Point(335, 29);
            this.comboBoxBanco.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(148, 21);
            this.comboBoxBanco.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "No Cheque";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxNocheque
            // 
            this.textBoxNocheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxNocheque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNocheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textBoxNocheque.Location = new System.Drawing.Point(200, 31);
            this.textBoxNocheque.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxNocheque.Multiline = true;
            this.textBoxNocheque.Name = "textBoxNocheque";
            this.textBoxNocheque.Size = new System.Drawing.Size(129, 17);
            this.textBoxNocheque.TabIndex = 31;
            this.textBoxNocheque.TextChanged += new System.EventHandler(this.textBoxNocheque_TextChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sucursal";
            this.Column2.Name = "Column2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Concepto de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Medio Pago";
            // 
            // comboBoxMediopago
            // 
            this.comboBoxMediopago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.comboBoxMediopago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMediopago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.comboBoxMediopago.FormattingEnabled = true;
            this.comboBoxMediopago.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque ",
            "Transferencia",
            "DEBITO",
            "EFECTIVO EN CAJA"});
            this.comboBoxMediopago.Location = new System.Drawing.Point(8, 32);
            this.comboBoxMediopago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxMediopago.Name = "comboBoxMediopago";
            this.comboBoxMediopago.Size = new System.Drawing.Size(185, 21);
            this.comboBoxMediopago.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Importe";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxImporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textBoxImporte.Location = new System.Drawing.Point(490, 30);
            this.textBoxImporte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxImporte.Multiline = true;
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(93, 17);
            this.textBoxImporte.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha Pago";
            // 
            // dataGridViewComprobantesPendientes
            // 
            this.dataGridViewComprobantesPendientes.AllowUserToAddRows = false;
            this.dataGridViewComprobantesPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridViewComprobantesPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewComprobantesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComprobantesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewComprobantesPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewComprobantesPendientes.Location = new System.Drawing.Point(5, 66);
            this.dataGridViewComprobantesPendientes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridViewComprobantesPendientes.Name = "dataGridViewComprobantesPendientes";
            this.dataGridViewComprobantesPendientes.Size = new System.Drawing.Size(648, 322);
            this.dataGridViewComprobantesPendientes.TabIndex = 32;
            this.dataGridViewComprobantesPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComprobantesPendientes_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No Factura";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Importe";
            this.Column4.Name = "Column4";
            // 
            // button2
            // 
            this.button2.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1497285708_Cancel;
            this.button2.Location = new System.Drawing.Point(812, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1497285414_Checkmark;
            this.button1.Location = new System.Drawing.Point(753, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 39);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources.if_document_print_118913;
            this.button4.Location = new System.Drawing.Point(698, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 39);
            this.button4.TabIndex = 47;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxImporte);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxMediopago);
            this.groupBox2.Controls.Add(this.textBoxNocheque);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxBanco);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(5, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(648, 63);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medios de Pago";
            // 
            // button5
            // 
            this.button5.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1497285414_Checkmark;
            this.button5.Location = new System.Drawing.Point(593, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 42);
            this.button5.TabIndex = 41;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewMediosPago
            // 
            this.dataGridViewMediosPago.AllowUserToAddRows = false;
            this.dataGridViewMediosPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMediosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMediosPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMP,
            this.ColumnNC,
            this.ColumnBanco,
            this.ColumnImporte});
            this.dataGridViewMediosPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridViewMediosPago.Location = new System.Drawing.Point(5, 469);
            this.dataGridViewMediosPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMediosPago.Name = "dataGridViewMediosPago";
            this.dataGridViewMediosPago.Size = new System.Drawing.Size(446, 83);
            this.dataGridViewMediosPago.TabIndex = 49;
            // 
            // ColumnMP
            // 
            this.ColumnMP.HeaderText = "Medio Pago";
            this.ColumnMP.Name = "ColumnMP";
            // 
            // ColumnNC
            // 
            this.ColumnNC.HeaderText = "No Cheque";
            this.ColumnNC.Name = "ColumnNC";
            // 
            // ColumnBanco
            // 
            this.ColumnBanco.HeaderText = "Banco";
            this.ColumnBanco.Name = "ColumnBanco";
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.HeaderText = "Importe";
            this.ColumnImporte.Name = "ColumnImporte";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.maskedTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.maskedTextBox2.Location = new System.Drawing.Point(698, 28);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(88, 21);
            this.maskedTextBox2.TabIndex = 51;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button6
            // 
            this.button6.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1497285708_Cancel;
            this.button6.Location = new System.Drawing.Point(495, 470);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 37);
            this.button6.TabIndex = 52;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // PagoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.button6);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.dataGridViewMediosPago);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxConceptopago);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewComprobantesPendientes);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Name = "PagoControl";
            this.Size = new System.Drawing.Size(920, 561);
            this.Load += new System.EventHandler(this.PagoControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprobantesPendientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediosPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxConceptopago;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNocheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMediopago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewComprobantesPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewMediosPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporte;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button6;
    }
}
