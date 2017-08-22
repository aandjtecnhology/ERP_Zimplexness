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
    public partial class ComprobanteControl : UserControl
    {
        public ComprobanteControl()
        {
            InitializeComponent();
        }

        private void buttonCancelarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                ComprobantesManager c = new ComprobantesManager();
                if (c.EliminarComprobante(textBoxSucursal.Text, textBoxNofactura.Text) == 1)
                {
                    MessageBox.Show("Se ha cancelado con exito el comprobante", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxProveedor.Text = "";
                    textBoxSucursal.Text = "";
                    textBoxNofactura.Text = "";


                }
                else
                {
                    MessageBox.Show("No se pudo cancelar el comprobante", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ComprobanteControl_Load(object sender, EventArgs e)
        {
            ComprobantesManager comp = new ComprobantesManager();
            ArticulosComprobanteManager detalles = new ArticulosComprobanteManager();
            comboBoxCentroCosto.DataSource = comp.ListarCentroCosto();
            comboBoxCentroCosto.DisplayMember = "CentroCosto";
            comboBoxCentroCosto.ValueMember = "IdCentroCosto";

            comboBoxContable.DataSource = comp.ListarContable();
            comboBoxContable.DisplayMember = "Contable";
            comboBoxContable.ValueMember = "IdContable";

            comboBoxTipoFactura.DataSource = comp.ListarTipoFactura();
            comboBoxTipoFactura.DisplayMember = "TipoFactura";
            comboBoxTipoFactura.ValueMember = "IdTipoFactura";

            comboBoxCondicionCompra.DataSource = comp.ListarCondicionCompra();
            comboBoxCondicionCompra.DisplayMember = "Condiciondecompra";
            comboBoxCondicionCompra.ValueMember = "IdCondicionCompra";

            comboBoxTipoComprobante.DataSource = comp.ListarTipoComprobantes();
            comboBoxTipoComprobante.DisplayMember = "TipoComprobante";
            comboBoxTipoComprobante.ValueMember = "IdTipoComprobante";

            comboBoxMedioPago.DataSource = comp.MediosdePago();
            comboBoxMedioPago.DisplayMember = "MediosPago";
            comboBoxMedioPago.ValueMember = "IdMedioPago";

            

            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(p.listarNombreProveedores().ToArray());
            this.comboBoxProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBoxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.comboBoxProveedor.AutoCompleteCustomSource = sourcename;
            //autocompletar combobox articulos

            ArticuloManager a = new ArticuloManager();
            AutoCompleteStringCollection sourcename2 = new AutoCompleteStringCollection();
            sourcename2.AddRange(a.ListarNombresArticulos().ToArray());
            this.comboBoxNombreArticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBoxNombreArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.comboBoxNombreArticulo.AutoCompleteCustomSource = sourcename2;





            //dataGridViewArticulos.DataSource = detalles.ListarArticulosComprobante(comp.DevolverIDporNoFactura(maskedTextBox1.Text, maskedTextBox2.Text));



        }

        private void buttonAgregar1_Click(object sender, EventArgs e)
        {
            try
            {



                if (comboBoxProveedor.Text == "" || textBoxSucursal.Text == "" || textBoxNofactura.Text == "")
                {
                    MessageBox.Show("Por Favor Ingrese el Proveedor y los Datos de la factura", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ComprobantesManager comp = new ComprobantesManager();
                    if (comp.ValidateComprobante(textBoxSucursal.Text, textBoxNofactura.Text) == 1)
                    {
                        MessageBox.Show("Ya se ingreso un comprobante con el mismo No.Factura", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                       
                        ProveedorManager p = new ProveedorManager();
                        CuentaCorrienteManager c = new CuentaCorrienteManager();
                        ProveedorManager prov = new ProveedorManager();
                       
                        if (int.Parse(comboBoxCondicionCompra.SelectedValue.ToString()) == 2)
                        {
                            if (c.ValidateCuentaCorrienteProveedor(p.DevolverIdPRoveedorporNombre(comboBoxProveedor.Text)) == 1)
                            {
                                if (comp.InsertarComprobante(textBoxSucursal.Text, textBoxNofactura.Text,
                                                    dateTimePickerFecha.Value,
                                                    dateTimePickerFechaVencimiento.Value,
                                                    int.Parse(comboBoxTipoComprobante.SelectedValue.ToString()),
                                                    int.Parse(comboBoxCentroCosto.SelectedValue.ToString()),
                                                    int.Parse(comboBoxTipoFactura.SelectedValue.ToString()),
                                                    int.Parse(comboBoxContable.SelectedValue.ToString()),
                                                    int.Parse(comboBoxCondicionCompra.SelectedValue.ToString()),
                                                    p.DevolverIdPRoveedorporNombre(comboBoxProveedor.Text)
                                                    ) == 1)
                                {

                                    MessageBox.Show("Datos principales de Comprobante insertados con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    comboBoxProveedor.Enabled = false;
                                    textBoxSucursal.Enabled = false;
                                    textBoxNofactura.Enabled = false;
                                    comboBoxCondicionCompra.Enabled = false;
                                    comboBoxTipoComprobante.Enabled = false;
                                    comboBoxContable.Enabled = false;
                                    comboBoxCentroCosto.Enabled = false;
                                    dateTimePickerFecha.Enabled = false;
                                    dateTimePickerFechaVencimiento.Enabled = false;
                                    comboBoxTipoFactura.Enabled = false;

                                }




                                else
                                {

                                    MessageBox.Show("Datos Erroneos", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe una cuenta corriente para este proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                            }

                        }
                        if (int.Parse(comboBoxCondicionCompra.SelectedValue.ToString()) == 1)
                        {
                            if (comp.InsertarComprobante(textBoxSucursal.Text, textBoxNofactura.Text,
                                                    dateTimePickerFecha.Value,
                                                    dateTimePickerFechaVencimiento.Value,
                                                    int.Parse(comboBoxTipoComprobante.SelectedValue.ToString()),
                                                    int.Parse(comboBoxCentroCosto.SelectedValue.ToString()),
                                                    int.Parse(comboBoxTipoFactura.SelectedValue.ToString()),
                                                    int.Parse(comboBoxContable.SelectedValue.ToString()),
                                                    int.Parse(comboBoxCondicionCompra.SelectedValue.ToString()),
                                                    p.DevolverIdPRoveedorporNombre(comboBoxProveedor.Text)
                                                    ) == 1)
                            {

                                MessageBox.Show("Datos principales de Comprobante insertados con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                comboBoxProveedor.Enabled = false;
                                textBoxSucursal.Enabled = false;
                                textBoxNofactura.Enabled = false;
                                comboBoxCondicionCompra.Enabled = false;
                                comboBoxTipoComprobante.Enabled = false;
                                comboBoxContable.Enabled = false;
                                comboBoxCentroCosto.Enabled = false;
                                comboBoxTipoFactura.Enabled = false;


                            }




                            else
                            {

                                MessageBox.Show("DataModel Erroneos", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }






                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxNombreArticulo.Text)==true||string.IsNullOrEmpty(textBoxCant.Text)==true)
                {
                    MessageBox.Show("Debe Ingresar el Articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (checkBoxIva1.Checked == true)
                    {
                        //INSERTAR EN LA TABLA ARTICULOS COMPROBANTES
                        DataModel.Table_DetallesComprobanteArticulos art = new DataModel.Table_DetallesComprobanteArticulos();
                        ArticuloManager a = new ArticuloManager();
                        ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
                        ComprobantesManager comp = new ComprobantesManager();

                        double precioxcant = 0;
                        double ivacalculado = 0;


                       
                        precioxcant = Convert.ToDouble(textBoxPrecioCompra.Text.Replace(".", ",")) * Convert.ToDouble(textBoxCant.Text.Replace(".", ","));

                        


                        detalleTableArticulocomprobantes.InsertarTableArticuloComprobante(comp.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text),
                        a.DevolverIDporNombre(comboBoxNombreArticulo.Text), Convert.ToDouble(textBoxCant.Text.Replace(".", ",")),
                        Math.Round(Convert.ToDouble(textBoxPrecioCompra.Text.Replace(".", ",")), 2), 0,
                        ivacalculado,
                        Math.Round(precioxcant+ivacalculado, 2));

                        List<DataModel.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text));
                        dataGridViewArticulos.AutoGenerateColumns = false;
                        dataGridViewArticulos.DataSource = listarticulo;
                        dataGridViewArticulos.AutoSize = false;

                        foreach (var item in listarticulo)
                        {
                            Column1.DataPropertyName = "Nombre";
                            Column2.DataPropertyName = "IdComprobante";
                            Column3.DataPropertyName = "Cantidad";
                            Column4.DataPropertyName = "Precio";
                            Column5.DataPropertyName = "Iva";
                            Column6.DataPropertyName = "Importe";
                            Column7.DataPropertyName = "idTable_DetallesComprobanteArticulos";


                        }
                        comboBoxNombreArticulo.Text = "";

                        textBoxCant.Clear();
                        textBoxPrecioCompra.Clear();



                    }

                    else
                    {



                        //INSERTAR EN LA TABLA ARTICULOS COMPROBANTES
                        DataModel.Table_DetallesComprobanteArticulos art = new DataModel.Table_DetallesComprobanteArticulos();
                        ArticuloManager a = new ArticuloManager();
                        ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
                        ComprobantesManager comp = new ComprobantesManager();

                        double precioxcant = 0;
                        double ivacalculado = 0;


                        ivacalculado = Convert.ToDouble(textBoxPrecioCompra.Text.Replace(".", ",")) * Convert.ToDouble(textBoxCant.Text.Replace(".", ",")) * Convert.ToDouble(textBoxIvaCompra.Text.Replace(".", ",")) / 100;
                        precioxcant = Convert.ToDouble(textBoxPrecioCompra.Text.Replace(".", ",")) * Convert.ToDouble(textBoxCant.Text.Replace(".", ","));




                        detalleTableArticulocomprobantes.InsertarTableArticuloComprobante(comp.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text),
                        a.DevolverIDporNombre(comboBoxNombreArticulo.Text), Convert.ToDouble(textBoxCant.Text.Replace(".", ",")),
                        Math.Round(Convert.ToDouble(textBoxPrecioCompra.Text.Replace(".", ",")), 2), Convert.ToDouble(textBoxIvaCompra.Text.Replace(".", ",")),
                        ivacalculado,
                        Math.Round(precioxcant + ivacalculado, 2));
                        List<DataModel.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text));
                        dataGridViewArticulos.AutoGenerateColumns = false;
                        dataGridViewArticulos.DataSource = listarticulo;
                        dataGridViewArticulos.AutoSize = false;

                        foreach (var item in listarticulo)
                        {
                            Column1.DataPropertyName = "Nombre";
                            Column2.DataPropertyName = "IdComprobante";
                            Column3.DataPropertyName = "Cantidad";
                            Column4.DataPropertyName = "Precio";
                            Column5.DataPropertyName = "Iva";
                            Column6.DataPropertyName = "Importe";
                            Column7.DataPropertyName = "idTable_DetallesComprobanteArticulos";


                        }
                        comboBoxNombreArticulo.Text = "";

                        textBoxCant.Clear();
                        textBoxPrecioCompra.Clear();




                    }





                   
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void buttonEliminarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                ArticulosComprobanteManager a = new ArticulosComprobanteManager();
                ComprobantesManager comp = new ComprobantesManager();
                if (a.EliminarArticuloComprobante(int.Parse(dataGridViewArticulos.CurrentRow.Cells["Column7"].Value.ToString())) == 1)
                {

                    MessageBox.Show("Se ha eliminado Correctamente");
                    List<DataModel.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text));
                    dataGridViewArticulos.AutoGenerateColumns = false;
                    dataGridViewArticulos.DataSource = listarticulo;
                    dataGridViewArticulos.AutoSize = true;

                    foreach (var item in listarticulo)
                    {
                        Column1.DataPropertyName = "Nombre";
                        Column2.DataPropertyName = "IdComprobante";
                        Column3.DataPropertyName = "Cantidad";
                        Column4.DataPropertyName = "Precio";
                        Column5.DataPropertyName = "Iva";
                        Column6.DataPropertyName = "Importe";
                        Column7.DataPropertyName = "idTable_DetallesComprobanteArticulos";

                    }

                }
                else
                {
                    MessageBox.Show("Error Al eliminar el Proveedor");

                }




            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //textBoxImportePago.Text.Replace(".",".");
                //textBoxIIBB.Text.Replace(",",".");
                //textBoxRetenciones.Text.Replace(".",",");
                if (string.IsNullOrEmpty(textBoxSucursal.Text) || string.IsNullOrEmpty(textBoxNofactura.Text))
                {
                    MessageBox.Show("Error, no tiene ninguna Factura Seleccionada para aplicarle el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (comboBoxCondicionCompra.SelectedValue.ToString() == "1")
                    {
                        ComprobantesManager c = new ComprobantesManager();
                        PagosManager p = new PagosManager();

                        Double iibb = Math.Round(Convert.ToDouble(textBoxIIBB.Text.Replace(".", ",")), 2);
                        Double retenciones = Math.Round(Convert.ToDouble(textBoxRetenciones.Text.Replace(".", ",")), 2);
                        Double otrosgastos = Math.Round(Convert.ToDouble(textBoxOtrosGastos.Text.Replace(".", ",")), 2);

                        c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text));
                        c.ActualizarEstado(c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text), 1);
                        c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text), iibb, retenciones, otrosgastos);

                        //insertar un pago en efectivo
                     

                        double roundednum = Math.Round(double.Parse(textBoxImportePago.Text.Replace(".", ",")), 2);


                        int idpago = p.InsertarPagoContado(dateTimePickerFecha.Value, textBoxConceptoPago.Text,roundednum);

                        p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text));

                        p.InsertarMediosPagoContado(int.Parse(comboBoxMedioPago.SelectedValue.ToString()),roundednum,idpago);

                        MessageBox.Show("Se Actualizaron todos los Datos del Comprobante con el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxSucursal.Clear();
                        textBoxNofactura.Clear();
                        textBoxIIBB.Text = "00,00";
                        textBoxRetenciones.Text = "00,00";
                        textBoxImportePago.Text = "00,00";
                        textBoxConceptoPago.Clear();
                        dataGridViewArticulos.DataSource = null;
                        comboBoxProveedor.Enabled = true;
                        textBoxSucursal.Enabled = true;
                        textBoxNofactura.Enabled = true;
                        comboBoxCondicionCompra.Enabled = true;
                        comboBoxTipoComprobante.Enabled = true;
                        comboBoxContable.Enabled = true;
                        comboBoxCentroCosto.Enabled = true;
                       
                        comboBoxTipoFactura.Enabled = true;
                    }
                    else
                    {
                        if (comboBoxCondicionCompra.SelectedValue.ToString() == "2")
                        {
                            ComprobantesManager c = new ComprobantesManager();
                            Double iibb = Math.Round(Convert.ToDouble(textBoxIIBB.Text.Replace(".", ",")), 2);
                            Double retenciones = Math.Round(Convert.ToDouble(textBoxRetenciones.Text.Replace(".", ",")), 2);
                            Double otrosgastos = Math.Round(Convert.ToDouble(textBoxOtrosGastos.Text.Replace(".", ",")), 2);


                            c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text));
                            c.ActualizarEstado(c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text), 2);
                            c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(textBoxSucursal.Text, textBoxNofactura.Text), iibb, retenciones, otrosgastos);


                            textBoxSucursal.Clear();
                            textBoxNofactura.Clear();
                            textBoxIIBB.Text = "00,00";
                            textBoxRetenciones.Text = "00,00";
                            textBoxImportePago.Text = "00,00";
                            textBoxConceptoPago.Clear();
                            dataGridViewArticulos.DataSource = null;
                            comboBoxProveedor.Enabled = true;
                            textBoxSucursal.Enabled = true;
                            textBoxNofactura.Enabled = true;
                            comboBoxCondicionCompra.Enabled = true;
                            comboBoxTipoComprobante.Enabled = true;
                            comboBoxContable.Enabled = true;
                            comboBoxCentroCosto.Enabled = true;
                           
                            comboBoxTipoFactura.Enabled = true;


                        }

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNombreArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
