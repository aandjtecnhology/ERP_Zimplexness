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
    public partial class PagoControl : UserControl
    {
        public PagoControl()
        {
            InitializeComponent();
        }

        private void PagoControl_Load(object sender, EventArgs e)
        {
            //declaracion de objeto comprobante
            ComprobantesManager comp = new ComprobantesManager();
            //llenar combobox
            

            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();
            var name = p.listarNombreProveedores();
            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(name.ToArray());
            this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.comboBox1.AutoCompleteCustomSource = sourcename;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //declaracion de comprobante y proveedor
                ComprobantesManager c = new ComprobantesManager();
                ProveedorManager p = new ProveedorManager();


                int idproveedor = p.DevolverIdPRoveedorporNombre(comboBox1.Text);


                var query = new PagosManager().ListFacturasPendientesPago(idproveedor);

                dataGridViewComprobantesPendientes.AutoGenerateColumns = false;
                dataGridViewComprobantesPendientes.DataSource = query;
                dataGridViewComprobantesPendientes.AutoSize = false;

                foreach (var item in query)
                {
                    Column1.DataPropertyName = "Fecha";
                    Column2.DataPropertyName = "Sucursal";
                    Column3.DataPropertyName = "NoFactura";
                    Column4.DataPropertyName = "Total";
                    Column5.DataPropertyName = "IdEstado";
                }






            }
            catch (Exception)
            {

                throw;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double importe = 0;
            foreach (DataGridViewRow row in dataGridViewComprobantesPendientes.Rows)
            {
                DataGridViewCheckBoxCell ck = row.Cells["Column6"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value) == true)
                {
                importe += Convert.ToDouble(row.Cells["Column4"].Value.ToString());
                }
            }
            textBox1.Text = importe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //VERIFICAR QUE HAYA AL MENOS UN COMPROBANTE SELECCIONADO

                foreach (DataGridViewRow row in dataGridViewComprobantesPendientes.Rows)
                {
                    DataGridViewCheckBoxCell ck2 = row.Cells["Column6"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck2.Value) == false || string.IsNullOrEmpty(maskedTextBox2.Text) == true || dataGridViewMediosPago.Rows.Count == 0)
                    {
                        MessageBox.Show("Error, Debe al menos seleccionar un comprobante para imputar o Insertar los Medios de Pagos Correspondientes", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        //VERIFICAR QUE EL PAGO NO SEA MENOR QUE LAS FACTURAS SELECCIONADAS
                        //CALCULAR TOTAL DE COMPROBANTES
                        double totalcomprobante = 0;
                        foreach (DataGridViewRow rown in dataGridViewComprobantesPendientes.Rows)
                        {
                            DataGridViewCheckBoxCell ck = rown.Cells["Column6"] as DataGridViewCheckBoxCell;
                            if (Convert.ToBoolean(ck.Value) == true)
                            {
                                totalcomprobante +=Math.Round( Convert.ToDouble(row.Cells["Column4"].Value.ToString()),2);
                            }
                        }
                        //CALCULAR TOTAL DE PAGOS
                        Double totalmediospago=0;
                        foreach (DataGridViewRow rown1 in dataGridViewMediosPago.Rows)
                        {
                            totalmediospago += Convert.ToDouble(rown1.Cells["ColumnImporte"].Value.ToString().Replace(".", ","));
                        }

                        if (totalcomprobante>totalmediospago==true)
                        {
                            MessageBox.Show("PRECAUCION, El total de Comprobantes es mayor que el Total del Pago","Sistema de Gestion de Compras",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            //INSERTAR EN LA TABLE PAGOS
                            //DECLARO LOS OBJETOS PARA MANEJAR COMPROBANTES Y PAGOS
                            ComprobantesManager c = new ComprobantesManager();
                            PagosManager p = new PagosManager();
                           
                            int idpago = 0;
                            //INSERTO EN LA TABLA PAGOS Y OBTENGO EL ULTIMO IDPAGO INSERTADO
                            idpago = p.InsertarPagos(Convert.ToDateTime(maskedTextBox2.Text), totalmediospago, textBoxConceptopago.Text);

                            //APLICO LOS PAGOS A CADA COMPROBANTE
                            //INSERTO EN LA TABLA DETALLE DE PAGOS Y ACTUALIZO EL ESTADO DE LOS COMPROBANTES A 1
                            foreach (DataGridViewRow row2 in dataGridViewComprobantesPendientes.Rows)
                            {
                                DataGridViewCheckBoxCell ck3 = row2.Cells["Column6"] as DataGridViewCheckBoxCell;
                                if (Convert.ToBoolean(ck3.Value) == true)
                                {
                                    p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura(row2.Cells["Column2"].Value.ToString(), row2.Cells["Column3"].Value.ToString()));
                                    //Actualizar EStado de Comprobante
                                    c.ActualizarEstado(c.DevolverIDporNoFactura(row2.Cells["Column2"].Value.ToString(), row2.Cells["Column3"].Value.ToString()), 1);
                                }
                            }


                            //INSERTO EN LA TABLA MEDIOS DE PAGO
                            foreach (DataGridViewRow row3 in dataGridViewMediosPago.Rows)
                            {
                                p.InsertarMediosPago(p.DevolverMedioPago(row3.Cells["ColumnMP"].Value.ToString()), row3.Cells["ColumnNC"].Value.ToString(), p.DevolverBanco(row3.Cells["ColumnBanco"].Value.ToString()), Convert.ToDouble(row3.Cells["ColumnImporte"].Value.ToString().Replace(".", ",")), idpago);

                            }

                            DialogResult dialogResult = MessageBox.Show("Se ha Aplicado el Pago, Desea Imprimir el Comprobante", "Sistema de Gestios de Compras v1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dialogResult == DialogResult.Yes)
                            {


                                ReportesForm reporte = new ReportesForm();
                                reporte.idpagoprop = idpago;
                                reporte.idpagoprop = idpago;
                                reporte.ShowDialog();


                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }
                            //BORRO TODOS LOS DATOS DEL DATA GRID Y DE LOS TEXTBOXES
                            dataGridViewMediosPago.Rows.Clear();
                            dataGridViewComprobantesPendientes.DataSource="";
                            maskedTextBox2.Clear();
                            textBoxConceptopago.Clear();
                            textBoxNocheque.Clear();
                            textBoxImporte.Clear();

                        }
                    }



                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNocheque_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //declaracion de comprobante y proveedor
               
                ProveedorManager p = new ProveedorManager();


               int idprov = p.DevolverIdPRoveedorporNombre(comboBox1.Text);
                ReporteDeuda ReportFrm = new ReporteDeuda();
                ReportFrm.idproveedor = idprov;
                ReportFrm.ShowDialog();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            //dataGridViewMediosPago.AutoGenerateColumns = false;
            
            string medio = comboBoxMediopago.SelectedItem.ToString();
            string banco = comboBoxBanco.SelectedItem.ToString();

            var listmedios = new String[] { medio, textBoxNocheque.Text, banco, textBoxImporte.Text };
            dataGridViewMediosPago.Rows.Add(listmedios);
          

           //dataGridViewMediosPago.Rows.Add(medio, textBoxNocheque.Text, banco, textBoxImporte.Text);


            dataGridViewMediosPago.AutoSize = false;







        }

        private void dataGridViewComprobantesPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                    dataGridViewMediosPago.Rows.RemoveAt(dataGridViewMediosPago.CurrentRow.Index);

                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
