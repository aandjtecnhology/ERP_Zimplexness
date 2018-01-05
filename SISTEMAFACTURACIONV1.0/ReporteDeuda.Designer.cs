namespace SISTEMAFACTURACIONV1._0
{
    partial class ReporteDeuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EncabezadoDeuda_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasPendientesPago_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoDeuda_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasPendientesPago_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EncabezadoDeuda_ResultBindingSource
            // 
            this.EncabezadoDeuda_ResultBindingSource.DataSource = typeof(SISTEMAFACTURACIONV1._0.Model.EncabezadoDeuda_Result);
            // 
            // FacturasPendientesPago_ResultBindingSource
            // 
            this.FacturasPendientesPago_ResultBindingSource.DataSource = typeof(SISTEMAFACTURACIONV1._0.Model.FacturasPendientesPago_Result);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EncabezaDeuda";
            reportDataSource1.Value = this.EncabezadoDeuda_ResultBindingSource;
            reportDataSource2.Name = "FacturasPendientesPago";
            reportDataSource2.Value = this.FacturasPendientesPago_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISTEMAFACTURACIONV1._0.InformeDeuda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(809, 401);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 401);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteDeuda";
            this.Text = "Reporte Deuda";
            this.Load += new System.EventHandler(this.ReporteDeuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoDeuda_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasPendientesPago_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EncabezadoDeuda_ResultBindingSource;
        private System.Windows.Forms.BindingSource FacturasPendientesPago_ResultBindingSource;
    }
}