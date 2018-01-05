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
    public partial class MetroConsultasComprobantes : UserControl
    {
        public MetroConsultasComprobantes()
        {
            InitializeComponent();
        }

        private void MetroConsultasComprobantes_Load(object sender, EventArgs e)
        {
            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(p.listarNombreProveedores().ToArray());
            metroTextBoxFiltroProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxFiltroProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxFiltroProveedor.AutoCompleteCustomSource = sourcename;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxFiltroProveedor.Text) == true)
                {
                    MessageBox.Show("Debe Ingresar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ComprobantesManager CManager = new ComprobantesManager();
                    ProveedorManager p = new ProveedorManager();



                    List<Model.FACTURASXPROVEEDORES_Result> factxproveedor = CManager.ListarFacturasXproveedores(metroDateTimeFechainicio.Value, metroDateTimeFechaFin.Value, p.DevolverIdPRoveedorporNombre(metroTextBoxFiltroProveedor.Text));
                    metroGridCompProveedores.AutoGenerateColumns = false;
                    metroGridCompProveedores.DataSource = factxproveedor;
                    metroGridCompProveedores.AutoSize = false;

                    foreach (var item in factxproveedor)
                    {
                        Fecha.DataPropertyName = "Fecha";
                        TipoFactura.DataPropertyName = "TipoFactura";
                        PuntoV.DataPropertyName = "Sucursal";
                        NoFactura.DataPropertyName = "NoFactura";
                        CondicionCompra.DataPropertyName = "Condiciondecompra";
                        Total.DataPropertyName = "Total";
                        Estado.DataPropertyName = "Estados";
                        //dataGridViewCuentaCorriente.Columns["IIBB"].Visible = false;
                        //dataGridViewCuentaCorriente.Columns["Retenciones"].Visible = false;
                        //dataGridViewCuentaCorriente.Columns["OtrosGastos"].Visible = false;
                        //dataGridViewCuentaCorriente.Columns["IvaCalculado"].Visible = false;
                        //dataGridViewCuentaCorriente.Columns["TipoComprobante"].Visible = false;
                        //dataGridViewCuentaCorriente.Columns["Condiciondecompra"].Visible = false;

                    }
                    //calcular de Comprobantes de Compras y Gastos 
                    double importe = 0;
                    foreach (DataGridViewRow row in metroGridCompProveedores.Rows)
                    {
                        importe += Convert.ToDouble(row.Cells["Total"].Value);
                    }
                    metroTextBoxTotal.Text = importe.ToString();
                    metroTextBoxTotal.Enabled = false;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
              



                ComprobantesManager CManager = new ComprobantesManager();
                ProveedorManager p = new ProveedorManager();



                List<Model.Gastos_ComprasxPeriodo_Result> ComprobantesComprasGastos = CManager.ListarFacturasComprasGastos(metroDateTimeInicio1.Value, metroDateTimeFin2.Value);
                metroGridTodosComprobantes.AutoGenerateColumns = false;
                metroGridTodosComprobantes.DataSource = ComprobantesComprasGastos;
                metroGridTodosComprobantes.AutoSize = false;

                foreach (var item in ComprobantesComprasGastos)
                {

                    Fecha.DataPropertyName = "Fecha";
                    ProveedorNombre.DataPropertyName = "NombreProveedor";
                    RazonSocial.DataPropertyName = "RazonSocial";
                    TipoComprobante.DataPropertyName = "TipoComprobante";
                    TipoFactura.DataPropertyName = "TipoFactura";
                    PuntoV.DataPropertyName = "Sucursal";
                    NoFactura.DataPropertyName = "NoFactura";
                    CondicionCompra.DataPropertyName = "Condiciondecompra";
                    Total.DataPropertyName = "Total";
                    IIBB.DataPropertyName = "IIBB";
                    Retenciones.DataPropertyName = "Retenciones";
                    OtrosGastos.DataPropertyName = "OtrosGastos";
                    Estados.DataPropertyName = "Estados";
                    Iva.DataPropertyName = "IvaCalculado";


                }


                double TotalComprobante = 0;
                double TotalIva = 0;
                double totalIIBB = 0;
                foreach (DataGridViewRow row in metroGridTodosComprobantes.Rows)
                {
                    TotalComprobante += Convert.ToDouble(row.Cells["ColumnTotal"].Value);
                    TotalIva += Convert.ToDouble(row.Cells["Iva"].Value);
                    totalIIBB += Convert.ToDouble(row.Cells["IIBB"].Value);
                }
                //metroTextBoxTotal.Text = TotalComprobante.ToString();
                //metroTextBoxTotal.Enabled = false;

                metroTextBoxTotalComprobantes.Text = TotalComprobante.ToString();
                metroTextBoxTotalIva.Text = TotalIva.ToString();
                metroTextBoxIIBB.Text = totalIIBB.ToString();
                metroTextBoxTotalComprobantes.Enabled = false;
                metroTextBoxTotalIva.Enabled = false;
                metroTextBoxIIBB.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroGridTodosComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButtonBuscarDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                ComprobantesManager CManager = new ComprobantesManager();

                if (metroCheckBoxTodos.Checked==true)
                {
                    List<Model.CuentasxPagarProveedores_Result> cuentasxpagar = CManager.ListarCuentasxPagarProveedores();
                    
                    //metroGridTodosComprobantes.AutoGenerateColumns = false;
                    metroGridDeudaProveedores.DataSource = cuentasxpagar;
                    double TotalComprobante = 0;

                    foreach (DataGridViewRow row in metroGridDeudaProveedores.Rows)
                    {
                        TotalComprobante += Convert.ToDouble(row.Cells[7].Value);

                    }
                    //metroTextBoxTotal.Text = TotalComprobante.ToString();
                    //metroTextBoxTotal.Enabled = false;

                    metroTextBoxTotalDeuda.Text = TotalComprobante.ToString();

                    metroTextBoxTotalDeuda.Enabled = false;


                }
                else { 



               
                List<Model.SP_DEUDASPROVEEDORES_Result> ComprobantesDeuda = CManager.ListarDeudasProveedores(metroDateTimeFechaInicioDeuda.Value, metroDateTimeFechaFinDeuda.Value);
                //metroGridTodosComprobantes.AutoGenerateColumns = false;
                metroGridDeudaProveedores.DataSource = ComprobantesDeuda;
                    //metroGridTodosComprobantes.AutoSize = false;

                    double TotalComprobante = 0;

                    foreach (DataGridViewRow row in metroGridDeudaProveedores.Rows)
                    {
                        TotalComprobante += Convert.ToDouble(row.Cells[7].Value);

                    }
                    //metroTextBoxTotal.Text = TotalComprobante.ToString();
                    //metroTextBoxTotal.Enabled = false;

                    metroTextBoxTotalDeuda.Text = TotalComprobante.ToString();

                    metroTextBoxTotalDeuda.Enabled = false;





                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {

                ReporteComprobantesForm FormComp = new ReporteComprobantesForm();
                FormComp.FechaInicio = metroDateTimeInicio1.Value;
                FormComp.FechaFin = metroDateTimeFin2.Value;
                FormComp.ShowDialog();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
