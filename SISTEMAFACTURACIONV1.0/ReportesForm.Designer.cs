namespace SISTEMAFACTURACIONV1._0
{
    partial class ReportesForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EncabezadoOrdenPago_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdenPago_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SeleccionarMediosDePagos_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoOrdenPago_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPago_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionarMediosDePagos_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EncabezadoOrdenPago_ResultBindingSource
            // 
            this.EncabezadoOrdenPago_ResultBindingSource.DataSource = typeof(SISTEMAFACTURACIONV1._0.Model.EncabezadoOrdenPago_Result);
            // 
            // OrdenPago_ResultBindingSource
            // 
            this.OrdenPago_ResultBindingSource.DataSource = typeof(SISTEMAFACTURACIONV1._0.Model.OrdenPago_Result);
            // 
            // SeleccionarMediosDePagos_ResultBindingSource
            // 
            this.SeleccionarMediosDePagos_ResultBindingSource.DataSource = typeof(SISTEMAFACTURACIONV1._0.Model.SeleccionarMediosDePagos_Result);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EncabezadoOrden";
            reportDataSource1.Value = this.EncabezadoOrdenPago_ResultBindingSource;
            reportDataSource2.Name = "OrdenPago";
            reportDataSource2.Value = this.OrdenPago_ResultBindingSource;
            reportDataSource3.Name = "MediosPago";
            reportDataSource3.Value = this.SeleccionarMediosDePagos_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISTEMAFACTURACIONV1._0.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(845, 470);
            this.reportViewer1.TabIndex = 6;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 550);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesForm";
            this.Text = "Orden de Pago";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoOrdenPago_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPago_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionarMediosDePagos_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EncabezadoOrdenPago_ResultBindingSource;
        private System.Windows.Forms.BindingSource OrdenPago_ResultBindingSource;
        private System.Windows.Forms.BindingSource SeleccionarMediosDePagos_ResultBindingSource;
    }
}