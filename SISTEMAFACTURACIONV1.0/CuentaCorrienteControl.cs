using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class CuentaCorrienteControl : UserControl
    {
        public CuentaCorrienteControl()
        {
            InitializeComponent();
        }

        private void CuentaCorrienteControl_Load(object sender, EventArgs e)
        {
            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(p.listarNombreProveedores().ToArray());
            this.comboBoxProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBoxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.comboBoxProveedor.AutoCompleteCustomSource = sourcename;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maskedTextBoxFechaInicio.Text)==true || string.IsNullOrEmpty(maskedTextBoxFechaFin.Text)==true)
                {
                    MessageBox.Show("Error,Debes agrerar las fechas de la consulta","Sistema de Gestion de Compras",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    ComprobantesManager CManager = new ComprobantesManager();
                    ProveedorManager p = new ProveedorManager();
                    dataGridViewCuentaCorriente.DataSource = CManager.ListarFacturasXproveedores(Convert.ToDateTime(maskedTextBoxFechaInicio.Text),Convert.ToDateTime(maskedTextBoxFechaFin.Text),p.DevolverIdPRoveedorporNombre(comboBoxProveedor.Text));
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
