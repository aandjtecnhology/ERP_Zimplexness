namespace SISTEMAFACTURACIONV1._0
{
    partial class CuentaCorrienteControl
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
            this.dataGridViewCuentaCorriente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentaCorriente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCuentaCorriente
            // 
            this.dataGridViewCuentaCorriente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewCuentaCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentaCorriente.Location = new System.Drawing.Point(5, 115);
            this.dataGridViewCuentaCorriente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridViewCuentaCorriente.Name = "dataGridViewCuentaCorriente";
            this.dataGridViewCuentaCorriente.Size = new System.Drawing.Size(752, 303);
            this.dataGridViewCuentaCorriente.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTodos);
            this.groupBox1.Controls.Add(this.comboBoxProveedor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBoxFechaFin);
            this.groupBox1.Controls.Add(this.maskedTextBoxFechaInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(526, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Busqueda";
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(276, 33);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(158, 17);
            this.checkBoxTodos.TabIndex = 10;
            this.checkBoxTodos.Text = "Todos Los Proveedores";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.comboBoxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(14, 33);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(230, 21);
            this.comboBoxProveedor.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = global::SISTEMAFACTURACIONV1._0.Properties.Resources._1498842292_Citycons_magnify;
            this.button1.Location = new System.Drawing.Point(391, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxFechaFin
            // 
            this.maskedTextBoxFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.maskedTextBoxFechaFin.Location = new System.Drawing.Point(159, 71);
            this.maskedTextBoxFechaFin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.maskedTextBoxFechaFin.Mask = "00/00/0000";
            this.maskedTextBoxFechaFin.Name = "maskedTextBoxFechaFin";
            this.maskedTextBoxFechaFin.Size = new System.Drawing.Size(85, 21);
            this.maskedTextBoxFechaFin.TabIndex = 7;
            this.maskedTextBoxFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxFechaInicio
            // 
            this.maskedTextBoxFechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.maskedTextBoxFechaInicio.Location = new System.Drawing.Point(14, 72);
            this.maskedTextBoxFechaInicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.maskedTextBoxFechaInicio.Mask = "00/00/0000";
            this.maskedTextBoxFechaInicio.Name = "maskedTextBoxFechaInicio";
            this.maskedTextBoxFechaInicio.Size = new System.Drawing.Size(85, 21);
            this.maskedTextBoxFechaInicio.TabIndex = 6;
            this.maskedTextBoxFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Proveedor";
            // 
            // CuentaCorrienteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.dataGridViewCuentaCorriente);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Name = "CuentaCorrienteControl";
            this.Size = new System.Drawing.Size(790, 463);
            this.Load += new System.EventHandler(this.CuentaCorrienteControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentaCorriente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCuentaCorriente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaFin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTodos;
    }
}
