using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Entity.SqlServer;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }
        public int idpagoprop { get; set; }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            PagosManager p = new PagosManager();

            EncabezadoOrdenPago_ResultBindingSource.DataSource = p.EncabezadoOdern(idpagoprop);
            OrdenPago_ResultBindingSource.DataSource = p.OrdenPago(idpagoprop);
            SeleccionarMediosDePagos_ResultBindingSource.DataSource = p.MediosPagos(idpagoprop);


            //EncabezadoOrdenPago_ResultBindingSource.DataSource = p.EncabezadoOrden(idpagoprop);
            //OrdenPago_ResultBindingSource.DataSource = p.OrdenPago(idpagoprop);
            
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
