using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class ReporteDeuda : MetroFramework.Forms.MetroForm
    {
        public ReporteDeuda()
        {
            InitializeComponent();
        }
        public int idproveedor { get; set; }
        private void ReporteDeuda_Load(object sender, EventArgs e)
        {

            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            PagosManager p = new PagosManager();
            EncabezadoDeuda_ResultBindingSource.DataSource = p.EncabezadpDeuda(idproveedor);
            FacturasPendientesPago_ResultBindingSource.DataSource = p.ListFacturasPendientesPago(idproveedor);


            this.reportViewer1.RefreshReport();

        }
    }
}
