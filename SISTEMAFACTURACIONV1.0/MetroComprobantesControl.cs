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
    public partial class MetroComprobantesControl : UserControl
    {
        public MetroComprobantesControl()
        {
            InitializeComponent();
           
        }

        private void MetroComprobantesControl_Load(object sender, EventArgs e)
        {
           
            ComprobantesManager comp = new ComprobantesManager();
            ArticulosComprobanteManager detalles = new ArticulosComprobanteManager();
            metroComboBoxCentroCosto.DataSource = comp.ListarCentroCosto();
            metroComboBoxCentroCosto.DisplayMember = "CentroCosto";
            metroComboBoxCentroCosto.ValueMember = "IdCentroCosto";

            metroComboBoxContable.DataSource = comp.ListarContable();
            metroComboBoxContable.DisplayMember = "Contable1";
            metroComboBoxContable.ValueMember = "IdContable";

            metroComboBoxTipoFactura.DataSource = comp.ListarTipoFactura();
            metroComboBoxTipoFactura.DisplayMember = "TipoFactura";
            metroComboBoxTipoFactura.ValueMember = "IdTipoFactura";

            metroComboBoxCondicionCompra.DataSource = comp.ListarCondicionCompra();
            metroComboBoxCondicionCompra.DisplayMember = "Condiciondecompra";
            metroComboBoxCondicionCompra.ValueMember = "IdCondicionCompra";

            metroComboBoxTipoComprobante.DataSource = comp.ListarTipoComprobantes();
            metroComboBoxTipoComprobante.DisplayMember = "TipoComprobante";
            metroComboBoxTipoComprobante.ValueMember = "IdTipoComprobante";

            metroComboBoxMedioPago.DataSource = comp.MediosdePago();
            metroComboBoxMedioPago.DisplayMember = "MediosPago1";
            metroComboBoxMedioPago.ValueMember = "IdMedioPago";



            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(p.listarNombreProveedores().ToArray());
            metroTextBoxProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxProveedor.AutoCompleteCustomSource = sourcename;
            //autocompletar combobox articulos

            ArticuloManager a = new ArticuloManager();
            AutoCompleteStringCollection sourcename2 = new AutoCompleteStringCollection();
            sourcename2.AddRange(a.ListarNombresArticulos().ToArray());
            this.metroTextBoxProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.metroTextBoxProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.metroTextBoxProducto.AutoCompleteCustomSource = sourcename2;
        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAgregarComprobante_Click(object sender, EventArgs e)
        {
            try
            {



                if (metroTextBoxProveedor.Text == "" || metroTextBoxPuntoV.Text == "" || metroTextBoxNoFactura.Text == "")
                {
                    MessageBox.Show("Por Favor Ingrese el Proveedor y los Datos de la factura", "Sistema de Gestion de Compras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    ProveedorManager p = new ProveedorManager();
                    ComprobantesManager comp = new ComprobantesManager();
                    if (comp.ValidateComprobante(p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text), metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text) == 1)
                    {
                        MessageBox.Show("Ya se ingreso un comprobante con el mismo No.Factura para este proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {


                        CuentaCorrienteManager c = new CuentaCorrienteManager();
                        ProveedorManager prov = new ProveedorManager();

                        if (int.Parse(metroComboBoxCondicionCompra.SelectedValue.ToString()) == 2)
                        {
                            if (c.ValidateCuentaCorrienteProveedor(p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)) == 1)
                            {
                                if (comp.InsertarComprobante(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text,
                                                    metroDateTimeFecha.Value,
                                                    metroDateTimeVencimiento.Value,
                                                    int.Parse(metroComboBoxTipoComprobante.SelectedValue.ToString()),
                                                    int.Parse(metroComboBoxCentroCosto.SelectedValue.ToString()),
                                                    int.Parse(metroComboBoxTipoFactura.SelectedValue.ToString()),
                                                    int.Parse(metroComboBoxContable.SelectedValue.ToString()),
                                                    int.Parse(metroComboBoxCondicionCompra.SelectedValue.ToString()),
                                                    p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)
                                                    ) == 1)
                                {

                                    MessageBox.Show("Datos principales de Comprobante insertados con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    metroTextBoxProveedor.Enabled = false;
                                    metroTextBoxPuntoV.Enabled = false;
                                    metroTextBoxNoFactura.Enabled = false;
                                    metroComboBoxCondicionCompra.Enabled = false;
                                    metroComboBoxTipoComprobante.Enabled = false;
                                    metroComboBoxContable.Enabled = false;
                                    metroComboBoxCentroCosto.Enabled = false;
                                    metroDateTimeFecha.Enabled = false;
                                    metroDateTimeVencimiento.Enabled = false;
                                    metroComboBoxTipoFactura.Enabled = false;

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
                        if (int.Parse(metroComboBoxCondicionCompra.SelectedValue.ToString()) == 1)
                        {

                            if (comp.InsertarComprobante(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text,
                                                   metroDateTimeFecha.Value,
                                                   metroDateTimeVencimiento.Value,
                                                   int.Parse(metroComboBoxTipoComprobante.SelectedValue.ToString()),
                                                   int.Parse(metroComboBoxCentroCosto.SelectedValue.ToString()),
                                                   int.Parse(metroComboBoxTipoFactura.SelectedValue.ToString()),
                                                   int.Parse(metroComboBoxContable.SelectedValue.ToString()),
                                                   int.Parse(metroComboBoxCondicionCompra.SelectedValue.ToString()),
                                                   p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)
                                                   ) == 1){
                                MessageBox.Show("Datos principales de Comprobante insertados con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                metroTextBoxProveedor.Enabled = false;
                                metroTextBoxPuntoV.Enabled = false;
                                metroTextBoxNoFactura.Enabled = false;
                                metroComboBoxCondicionCompra.Enabled = false;
                                metroComboBoxTipoComprobante.Enabled = false;
                                metroComboBoxContable.Enabled = false;
                                metroComboBoxCentroCosto.Enabled = false;
                                metroDateTimeFecha.Enabled = false;
                                metroDateTimeVencimiento.Enabled = false;
                                metroComboBoxTipoFactura.Enabled = false;
                            }


                            else
                            {

                                MessageBox.Show("Model Erroneos", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void metroTextBoxPuntoV_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(metroTextBoxPuntoV.Text)==false)
            {
                metroTextBoxPuntoV.Text = string.Format("{0:0000}", int.Parse(metroTextBoxPuntoV.Text));
            }
            else
            {
                
            }

            }

        private void metroButtonAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Model.DetallesComprobanteArticulos art = new Model.DetallesComprobanteArticulos();
                ArticuloManager a = new ArticuloManager();
                ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
                ComprobantesManager comp = new ComprobantesManager();
               // Model.DetallesComprobanteArticulos art = new Model.DetallesComprobanteArticulos();
               // ArticuloManager a = new ArticuloManager();
                //ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
               // ComprobantesManager comp = new ComprobantesManager();
                ProveedorManager p = new ProveedorManager();
                if (string.IsNullOrEmpty(metroTextBoxProducto.Text) == true || string.IsNullOrEmpty(metroTextBoxCantidad.Text) == true || String.IsNullOrEmpty(metroTextBoxPuntoV.Text) == true || string.IsNullOrEmpty(metroTextBoxNoFactura.Text) == true)
                {
                    MessageBox.Show("Debe Ingresar el Articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (metroCheckBoxIvaExento.Checked == true)
                    {
                        //INSERTAR EN LA TABLA ARTICULOS COMPROBANTES
                        

                        double precioxcant = 0;
                        double ivacalculado = 0;



                        precioxcant = Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ","));




                        detalleTableArticulocomprobantes.InsertarTableArticuloComprobante(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)),
                        a.DevolverIDporNombre(metroTextBoxProducto.Text), Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ",")),
                        Math.Round(Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")), 2), 0,
                        ivacalculado,
                        Math.Round(precioxcant + ivacalculado, 2));

                        List<Model.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                        metroGridProductosServicios.AutoGenerateColumns = false;
                        metroGridProductosServicios.DataSource = listarticulo;
                        metroGridProductosServicios.AutoSize = false;

                        foreach (var item in listarticulo)
                        {
                            ID.DataPropertyName = "idTable_DetallesComprobanteArticulos";
                            IDComprobante.DataPropertyName = "IdComprobante";
                            Producto.DataPropertyName = "Nombre";
                            Cantidad.DataPropertyName = "Cantidad";
                            PrecioCompra.DataPropertyName = "Precio";
                            Iva.DataPropertyName = "Iva";
                            Importe.DataPropertyName = "Importe";



                        }
                        metroTextBoxProducto.Text = "";

                        metroTextBoxCantidad.Clear();
                        metroTextBoxPrecio.Clear();

                        metroCheckBoxIvaExento.Checked = false;

                    }

                    else
                    {

                      



                            //INSERTAR EN LA TABLA ARTICULOS COMPROBANTES
                           

                            double precioxcant = 0;
                            double ivacalculado = 0;


                            ivacalculado = Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxIva.Text.Replace(".", ",")) / 100;
                            precioxcant = Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ","));




                            detalleTableArticulocomprobantes.InsertarTableArticuloComprobante(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text,p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)),
                            a.DevolverIDporNombre(metroTextBoxProducto.Text), Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ",")),
                            Math.Round(Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")), 2), Convert.ToDouble(metroTextBoxIva.Text.Replace(".", ",")),
                            ivacalculado,
                            Math.Round(precioxcant + ivacalculado, 2));
                            List<Model.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                            metroGridProductosServicios.AutoGenerateColumns = false;
                            metroGridProductosServicios.DataSource = listarticulo;
                            metroGridProductosServicios.AutoSize = false;

                            foreach (var item in listarticulo)
                            {
                                ID.DataPropertyName = "idTable_DetallesComprobanteArticulos";
                                IDComprobante.DataPropertyName = "IdComprobante";
                                Producto.DataPropertyName = "Nombre";
                                Cantidad.DataPropertyName = "Cantidad";
                                PrecioCompra.DataPropertyName = "Precio";
                                Iva.DataPropertyName = "Iva";
                                Importe.DataPropertyName = "Importe";


                            }
                            metroTextBoxProducto.Text = "";

                            metroTextBoxCantidad.Clear();
                            metroTextBoxPrecio.Clear();


                        }

                    }







                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButtonCancelarComprobante_Click(object sender, EventArgs e)
        {
            try
            {

                if (metroTextBoxProveedor.Text == "" || metroTextBoxPuntoV.Text == "" || metroTextBoxNoFactura.Text == "")
                {
                    MessageBox.Show("No tiene Factura para Cancelar, ingrese Punto V, No Factura, y Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {




                    ComprobantesManager c = new ComprobantesManager();
                    if (c.EliminarComprobante(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text) == 1)
                    {
                        MessageBox.Show("Se ha cancelado con exito el comprobante", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        metroTextBoxPuntoV.Clear();
                        metroTextBoxNoFactura.Clear();
                        metroTextBoxProveedor.Enabled = true;
                        metroTextBoxPuntoV.Enabled = true;
                        metroTextBoxNoFactura.Enabled = true;
                        metroComboBoxCondicionCompra.Enabled = true;
                        metroComboBoxTipoComprobante.Enabled = true;
                        metroComboBoxContable.Enabled = true;
                        metroComboBoxCentroCosto.Enabled = true;
                        metroComboBoxTipoFactura.Enabled = true;
                        metroDateTimeFecha.Enabled = true;
                        metroDateTimeVencimiento.Enabled = true;


                    }
                    else
                    {
                        MessageBox.Show("No se pudo cancelar el comprobante", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTextBoxPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Model.DetallesComprobanteArticulos art = new Model.DetallesComprobanteArticulos();
                    ArticuloManager a = new ArticuloManager();
                    ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
                    ComprobantesManager comp = new ComprobantesManager();
                    
                    ProveedorManager p = new ProveedorManager();
                    if (string.IsNullOrEmpty(metroTextBoxProducto.Text) == true || string.IsNullOrEmpty(metroTextBoxCantidad.Text) == true || String.IsNullOrEmpty(metroTextBoxPuntoV.Text) == true || string.IsNullOrEmpty(metroTextBoxNoFactura.Text) == true)
                    {
                        MessageBox.Show("Debe Ingresar el Articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (metroCheckBoxIvaExento.Checked == true)
                        {
                            ////INSERTAR EN LA TABLA ARTICULOS COMPROBANTES
                            //Model.DetallesComprobanteArticulos art = new Model.DetallesComprobanteArticulos();
                            //ArticuloManager a = new ArticuloManager();
                            //ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
                            //ComprobantesManager comp = new ComprobantesManager();

                            double precioxcant = 0;
                            double ivacalculado = 0;



                            precioxcant = Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ","));




                            detalleTableArticulocomprobantes.InsertarTableArticuloComprobante(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)),
                            a.DevolverIDporNombre(metroTextBoxProducto.Text), Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ",")),
                            Math.Round(Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")), 2), 0,
                            ivacalculado,
                            Math.Round(precioxcant + ivacalculado, 2));

                            List<Model.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                            metroGridProductosServicios.AutoGenerateColumns = false;
                            metroGridProductosServicios.DataSource = listarticulo;
                            metroGridProductosServicios.AutoSize = false;

                            foreach (var item in listarticulo)
                            {
                                ID.DataPropertyName = "idTable_DetallesComprobanteArticulos";
                                IDComprobante.DataPropertyName = "IdComprobante";
                                Producto.DataPropertyName = "Nombre";
                                Cantidad.DataPropertyName = "Cantidad";
                                PrecioCompra.DataPropertyName = "Precio";
                                Iva.DataPropertyName = "Iva";
                                Importe.DataPropertyName = "Importe";



                            }
                            metroTextBoxProducto.Text = "";

                            metroTextBoxCantidad.Clear();
                            metroTextBoxPrecio.Clear();

                            metroCheckBoxIvaExento.Checked = false;



                        }

                        else
                        {



                            //INSERTAR EN LA TABLA ARTICULOS COMPROBANTES
                            //Model.DetallesComprobanteArticulos art = new Model.DetallesComprobanteArticulos();
                            //ArticuloManager a = new ArticuloManager();
                            //ArticulosComprobanteManager detalleTableArticulocomprobantes = new ArticulosComprobanteManager();
                            //ComprobantesManager comp = new ComprobantesManager();

                            double precioxcant = 0;
                            double ivacalculado = 0;


                            ivacalculado = Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxIva.Text.Replace(".", ",")) / 100;
                            precioxcant = Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")) * Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ","));




                            detalleTableArticulocomprobantes.InsertarTableArticuloComprobante(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)),
                            a.DevolverIDporNombre(metroTextBoxProducto.Text), Convert.ToDouble(metroTextBoxCantidad.Text.Replace(".", ",")),
                            Math.Round(Convert.ToDouble(metroTextBoxPrecio.Text.Replace(".", ",")), 2), Convert.ToDouble(metroTextBoxIva.Text.Replace(".", ",")),
                            ivacalculado,
                            Math.Round(precioxcant + ivacalculado, 2));
                            List<Model.View_DetalleArticuloComprobante> listarticulo = comp.VistaComprobantesArticulos(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, p.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                            metroGridProductosServicios.AutoGenerateColumns = false;
                            metroGridProductosServicios.DataSource = listarticulo;
                            metroGridProductosServicios.AutoSize = false;

                            foreach (var item in listarticulo)
                            {
                                ID.DataPropertyName = "idTable_DetallesComprobanteArticulos";
                                IDComprobante.DataPropertyName = "IdComprobante";
                                Producto.DataPropertyName = "Nombre";
                                Cantidad.DataPropertyName = "Cantidad";
                                PrecioCompra.DataPropertyName = "Precio";
                                Iva.DataPropertyName = "Iva";
                                Importe.DataPropertyName = "Importe";


                            }
                            metroTextBoxProducto.Text = "";

                            metroTextBoxCantidad.Clear();
                            metroTextBoxPrecio.Clear();




                        }







                    }
                }
                catch (Exception)
                {

                    throw;
                }


            }
        }

        private void metroButtonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorManager prov = new ProveedorManager();

                //textBoxImportePago.Text.Replace(".",".");
                //textBoxIIBB.Text.Replace(",",".");
                //textBoxRetenciones.Text.Replace(".",",");
                if (string.IsNullOrEmpty(metroTextBoxPuntoV.Text) || string.IsNullOrEmpty(metroTextBoxNoFactura.Text)||metroGridProductosServicios.Rows.Count==0)
                {
                    MessageBox.Show("Error, No posee ningun comprobante para Confirmar", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (metroComboBoxCondicionCompra.SelectedValue.ToString()== "1")
                    {
                        ComprobantesManager c = new ComprobantesManager();
                        PagosManager p = new PagosManager();

                        double iibb = Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".",","));
                        double retenciones = Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ","));
                        double otrosgastos = Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ","));
                        double roundednum = Convert.ToDouble(metroTextBoxImporte.Text.Replace(".", ","));
                        double retiva1 = Convert.ToDouble(metroTextBoxPercepcion.Text.Replace(".", ","));

                        c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                        c.ActualizarEstado(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), 1);
                        c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)),Math.Round( iibb,2), Math.Round(retenciones, 2), Math.Round(otrosgastos, 2) , Math.Round(retiva1, 2) );

                        //insertar un pago en efectivo


                       


                        int idpago = p.InsertarPagoContado(metroDateTimeFecha.Value, metroTextBoxConceptoPago.Text,Math.Round( roundednum,2));

                        p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));

                        p.InsertarMediosPagoContado(int.Parse(metroComboBoxMedioPago.SelectedValue.ToString()),Math.Round( roundednum,2), idpago);

                        MessageBox.Show("Se Actualizaron todos los Datos del Comprobante con el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        metroTextBoxPuntoV.Clear();
                        metroTextBoxNoFactura.Clear();
                        metroTextBoxConceptoPago.Clear();
                        metroTextBoxPercepcion.Clear();
                        metroTextBoxIIBB.Clear();
                        metroTextBoxRetenciones.Clear();
                        metroTextBoxImporte.Clear();
                        metroTextBoxIIBB.Text = "00,00";
                        metroTextBoxRetenciones.Text = "00,00";
                        metroTextBoxOtrosGastos.Text = "00,00";
                        metroTextBoxImporte.Text = "00,00";
                        metroTextBoxPercepcion.Text = "00,00";
                       
                        metroGridProductosServicios.DataSource = null;
                        metroTextBoxProveedor.Enabled = true;
                        metroTextBoxPuntoV.Enabled = true;
                        metroTextBoxNoFactura.Enabled = true;
                        metroComboBoxCondicionCompra.Enabled = true;
                        metroComboBoxTipoComprobante.Enabled = true;
                        metroComboBoxContable.Enabled = true;
                        metroComboBoxCentroCosto.Enabled = true;

                        metroComboBoxTipoFactura.Enabled = true;
                        metroDateTimeFecha.Enabled = true;
                        metroDateTimeVencimiento.Enabled = true;

                    }
                    else
                    {
                        if (metroComboBoxCondicionCompra.SelectedValue.ToString() == "2")
                        {
                            ComprobantesManager c = new ComprobantesManager();
                            Double iibb = Math.Round(Convert.ToDouble(metroTextBoxIIBB.Text.Replace(".", ",")), 2);
                            Double retenciones = Math.Round(Convert.ToDouble(metroTextBoxRetenciones.Text.Replace(".", ",")), 2);
                            Double otrosgastos = Math.Round(Convert.ToDouble(metroTextBoxOtrosGastos.Text.Replace(".", ",")), 2);
                            double ivaRet = Math.Round(Convert.ToDouble(metroTextBoxIva.Text.Replace(".", ",")),2);

                            c.ActualizarImporteComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                            c.ActualizarEstado(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), 2);
                            c.ActualizarOtrosGastosComprobante(c.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)), iibb, retenciones, otrosgastos,ivaRet);

                            //Como es condicion de compra cuenta corriente no se ingresa ningun pago




                            metroTextBoxPuntoV.Clear();
                            metroTextBoxNoFactura.Clear();
                            metroTextBoxPercepcion.Clear();
                            metroTextBoxIIBB.Clear();
                            metroTextBoxRetenciones.Clear();
                            metroTextBoxImporte.Clear();
                            metroTextBoxOtrosGastos.Clear();

                            metroTextBoxIIBB.Text = "00,00";
                            metroTextBoxRetenciones.Text = "00,00";
                            metroTextBoxOtrosGastos.Text = "00,00";
                            metroTextBoxPercepcion.Text = "00,00";
                            metroTextBoxImporte.Text = "00,00";
                           
                            metroGridProductosServicios.DataSource = null;
                            metroTextBoxProveedor.Enabled = true;
                            metroTextBoxPuntoV.Enabled = true;
                            metroTextBoxNoFactura.Enabled = true;
                            metroComboBoxCondicionCompra.Enabled = true;
                            metroComboBoxTipoComprobante.Enabled = true;
                            metroComboBoxContable.Enabled = true;
                            metroComboBoxCentroCosto.Enabled = true;

                            metroComboBoxTipoFactura.Enabled = true;
                            metroDateTimeFecha.Enabled = true;
                            metroDateTimeVencimiento.Enabled = true;


                        }

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void metroButtonCancelarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorManager prov = new ProveedorManager();
                if (metroGridProductosServicios.Rows.Count == 0)
                {
                    MessageBox.Show("Error, no tiene articulo para eliminar","Sistema de Gestion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {



                    ArticulosComprobanteManager a = new ArticulosComprobanteManager();
                    ComprobantesManager comp = new ComprobantesManager();
                    if (a.EliminarArticuloComprobante(int.Parse(metroGridProductosServicios.CurrentRow.Cells["ID"].Value.ToString())) == 1)
                    {

                        MessageBox.Show("Se ha eliminado Correctamente");
                        List<Model.SeleccionarDetalleComprobantesArticulos_Result> listarticulo = a.SeleccionarDetallesComprobantesArticulos(comp.DevolverIDporNoFactura(metroTextBoxPuntoV.Text, metroTextBoxNoFactura.Text, prov.DevolverIdPRoveedorporNombre(metroTextBoxProveedor.Text)));
                        metroGridProductosServicios.AutoGenerateColumns = false;
                        metroGridProductosServicios.DataSource = listarticulo;
                        metroGridProductosServicios.AutoSize = true;

                        foreach (var item in listarticulo)
                        {
                            ID.DataPropertyName = "idTable_DetallesComprobanteArticulos";
                            IDComprobante.DataPropertyName = "IdComprobante";
                            Producto.DataPropertyName = "Nombre";
                            Cantidad.DataPropertyName = "Cantidad";
                            PrecioCompra.DataPropertyName = "Precio";
                            Iva.DataPropertyName = "Iva";
                            Importe.DataPropertyName = "Importe";


                        }

                    }
                    else
                    {
                        MessageBox.Show("Error Al eliminar el Proveedor");

                    }

                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTextBoxIIBB_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTimeFecha_ValueChanged(object sender, EventArgs e)
        {
            metroDateTimeVencimiento.Value = metroDateTimeFecha.Value;
        }

        private void metroTextBoxNoFactura_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(metroTextBoxNoFactura.Text)==false)
            {
                metroTextBoxNoFactura.Text = string.Format("{0:00000000}", int.Parse(metroTextBoxNoFactura.Text));
            }
            else
            {

            }

        }
    }
}
