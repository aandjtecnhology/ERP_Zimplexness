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
    public partial class ConsultaComprobantesControl : UserControl
    {
        public ConsultaComprobantesControl()
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
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewCuentaCorriente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxTodos.Checked == false)
                {
                    if (string.IsNullOrEmpty(comboBoxProveedor.Text) == true)
                    {
                        MessageBox.Show("Debe Ingresar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ComprobantesManager CManager = new ComprobantesManager();
                        ProveedorManager p = new ProveedorManager();



                        List<Model.FACTURASXPROVEEDORES_Result> factxproveedor = CManager.ListarFacturasXproveedores(dateTimePickerFechainicio.Value, dateTimePickerFechaFin.Value, p.DevolverIdPRoveedorporNombre(comboBoxProveedor.Text));
                        dataGridViewCuentaCorriente.AutoGenerateColumns = false;
                        dataGridViewCuentaCorriente.DataSource = factxproveedor;
                        dataGridViewCuentaCorriente.AutoSize = false;

                        foreach (var item in factxproveedor)
                        {
                            Fecha.DataPropertyName = "Fecha";
                            Proveedor.DataPropertyName = "NombreProveedor";
                            TipoComprobante.DataPropertyName = "TipoComprobante";
                            TipoFactura.DataPropertyName = "TipoFactura";
                            Sucursal.DataPropertyName = "Sucursal";
                            NoFactura.DataPropertyName = "NoFactura";
                            CondicionCompra.DataPropertyName = "Condiciondecompra";
                            Total.DataPropertyName = "Total";
                            Estados.DataPropertyName = "Estados";
                            //dataGridViewCuentaCorriente.Columns["IIBB"].Visible = false;
                            //dataGridViewCuentaCorriente.Columns["Retenciones"].Visible = false;
                            //dataGridViewCuentaCorriente.Columns["OtrosGastos"].Visible = false;
                            //dataGridViewCuentaCorriente.Columns["IvaCalculado"].Visible = false;
                            //dataGridViewCuentaCorriente.Columns["TipoComprobante"].Visible = false;
                            //dataGridViewCuentaCorriente.Columns["Condiciondecompra"].Visible = false;

                        }
                        //calcular de Comprobantes de Compras y Gastos 
                        double importe = 0;
                        foreach (DataGridViewRow row in dataGridViewCuentaCorriente.Rows)
                        {
                            importe += Convert.ToDouble(row.Cells["Total"].Value);
                        }
                        textBoxTotalComprobantes.Text = importe.ToString();
                        textBoxTotalComprobantes.Enabled = false;

                    }
                }
                else
                {
                    //calcular de Comprobantes de Compras y Gastos 
                    double importe = 0;
                    double IvaAcumulado = 0;
                    double totalIIBB = 0;
                    double totalRetenciones = 0;
                    double totalOtrosGastos = 0;

                    if (checkBoxTodos.Checked == true)
                    {


                        ComprobantesManager CManager = new ComprobantesManager();
                        ProveedorManager p = new ProveedorManager();



                        List<Model.Gastos_ComprasxPeriodo_Result> ComprobantesComprasGastos = CManager.ListarFacturasComprasGastos(dateTimePickerFechainicio.Value, dateTimePickerFechaFin.Value);
                        dataGridViewCuentaCorriente.AutoGenerateColumns = false;
                        dataGridViewCuentaCorriente.DataSource = ComprobantesComprasGastos;
                        dataGridViewCuentaCorriente.AutoSize = false;

                        foreach (var item in ComprobantesComprasGastos)
                        {

                            Fecha.DataPropertyName = "Fecha";
                            Proveedor.DataPropertyName = "NombreProveedor";
                            RazonSocial.DataPropertyName = "RazonSocial";
                            TipoComprobante.DataPropertyName = "TipoComprobante";
                            TipoFactura.DataPropertyName = "TipoFactura";
                            Sucursal.DataPropertyName = "Sucursal";
                            NoFactura.DataPropertyName = "NoFactura";
                            CondicionCompra.DataPropertyName = "Condiciondecompra";
                            Total.DataPropertyName = "Total";
                            IIBB.DataPropertyName = "IIBB";
                            Retenciones.DataPropertyName = "Retenciones";
                            OtrosGastos.DataPropertyName = "OtrosGastos";
                            Estados.DataPropertyName = "Estados";
                            Iva.DataPropertyName = "IvaCalculado";


                        }


                        foreach (DataGridViewRow row in dataGridViewCuentaCorriente.Rows)
                        {
                            importe += Convert.ToDouble(row.Cells["Total"].Value);
                            IvaAcumulado += Convert.ToDouble(row.Cells["Iva"].Value);
                            totalIIBB += Convert.ToDouble(row.Cells["IIBB"].Value);
                            totalRetenciones += Convert.ToDouble(row.Cells["Retenciones"].Value);
                            totalOtrosGastos += Convert.ToDouble(row.Cells["OtrosGastos"].Value);

                        }
                        //muestros los totales en los textboxes
                        textBoxTotalComprobantes.Text = importe.ToString();
                        textBoxIva.Text = IvaAcumulado.ToString();
                        textBoxIIBB.Text = totalIIBB.ToString();
                        textBoxRetenciones.Text = totalRetenciones.ToString();
                        textBoxOtrosGastos.Text = totalOtrosGastos.ToString();
                        textBoxIva.Enabled = false;
                        textBoxTotalComprobantes.Enabled = false;
                        textBoxIIBB.Enabled = false;
                        textBoxRetenciones.Enabled = false;
                        textBoxOtrosGastos.Enabled = false;

                        chart1.Series["TotalComprobantes"].Points.AddXY("Total Gastos", importe);
                        chart1.Series["TotalComprobantes"].Points.AddXY("Total Iva", IvaAcumulado);
                        chart1.Series["TotalComprobantes"].Points.AddXY("Total Ingresos Brutos", totalIIBB);





                    }







                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
