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
    public partial class MetroProveedores : UserControl
    {
        public MetroProveedores()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
 

        }

        private void MetroProveedores_Load(object sender, EventArgs e)
        {
            Provincia_localidad PLmanager = new Provincia_localidad();
            metroComboBoxPROVINCIA.DataSource = PLmanager.ListarProvincias();
            metroComboBoxLOCALIDAD.DataSource = PLmanager.ListarLocalidades();

            metroComboBoxPROVINCIA.DisplayMember = "Provincias1";
            metroComboBoxPROVINCIA.ValueMember = "IDProvincias";

            metroComboBoxLOCALIDAD.DisplayMember = "Localidades1";
            metroComboBoxLOCALIDAD.ValueMember = "IdLocalidad";

            metroGrid1.DataSource = new ProveedorManager().ListarProveedores();

            ProveedorManager p = new ProveedorManager();

            //llenar combo productor
            metroComboBoxNOMBREPRODUCTOR.DataSource = p.ListarProductorSeguro();
            metroComboBoxNOMBREPRODUCTOR.DisplayMember = "Nombre";
            metroComboBoxNOMBREPRODUCTOR.ValueMember = "IdProductorSeguro";

            //llenar combo de rubros
            metroComboBoxRUBROS.DataSource = p.ListarRubros();
            metroComboBoxRUBROS.DisplayMember = "Descripcion";
            metroComboBoxRUBROS.ValueMember = "IDRubroProveedor";

        }

        private void metroTextBoxFILTRONOMBRE_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            metroGrid1.DataSource = pm.filtrarproveedores(metroTextBoxFILTRONOMBRE.Text);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            metroGrid1.DataSource = pm.filtrarproveedoresRazon(metroTextBoxfiltrorazon.Text);
        }

        private void metroTextBoxfiltrorubro_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            metroGrid1.DataSource = pm.filtrarPorRubros(metroTextBoxfiltrorubro.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //declarando todos los objetos para manejar proveedores, localidad y provincia
                ProveedorManager pm = new ProveedorManager();
                CuentaCorrienteManager c = new CuentaCorrienteManager();
                //validar la entrada de los datos
                if (string.IsNullOrEmpty(metroTextBoxNOMBRE.Text) || string.IsNullOrEmpty(metroTextBoxCUIT.Text) || string.IsNullOrEmpty(metroTextBoxRAZON.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre, Razon y CUIT", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //validar el cuit del proveedor
                    if (pm.ValidateProveedor(metroTextBoxCUIT.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un proveedor con el mismo CUIT", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        //Crear un proveedor con cuenta corriente
                        if (metroCheckCUENTACORRIENTE.Checked == true || metroCheckBoxPRODUCTOR.Checked == true)
                        {
                            int idproveedor = 0;
                            //Insertar en la tabla proveedores
                            Model.Proveedores prov = new Model.Proveedores();
                            prov.Nombre = metroTextBoxNOMBRE.Text;
                            prov.Razon = metroTextBoxRAZON.Text;
                            prov.Cuit = metroTextBoxCUIT.Text;
                            prov.FechaIngreso = metroDateTimeFECHA.Value;
                            prov.IngresosBrutos = metroTextBoxIIBB.Text;
                            prov.Telefono = metroTextBoxTELEFONO.Text;
                            prov.Direccion = metroTextBoxDIRECCION.Text;
                            prov.IDProvincia = metroComboBoxPROVINCIA.SelectedValue.ToString();
                            prov.IDLocalidad = int.Parse(metroComboBoxLOCALIDAD.SelectedValue.ToString());
                            prov.IDRubro = int.Parse(metroComboBoxRUBROS.SelectedValue.ToString());
                            idproveedor = pm.insertar_proveedor(prov);

                            //Crear Una cuenta corriente para el proveedor
                            Model.CuentaCorriente cuenta = new Model.CuentaCorriente();
                            cuenta.Nombre = metroTextBoxCUIT.Text;
                            cuenta.Vencimiento = int.Parse(metroComboBoxVENCIMIENTO.Text);
                            cuenta.IDProveedor = pm.devolverIDProveedorCUIT(metroTextBoxCUIT.Text);
                            pm.CrearCuentaCorriente(cuenta);

                            //insertar productor de seguro

                            if (metroCheckBoxPRODUCTOR.Checked==true)
                            {
                                pm.InsertarProductorSeguro(idproveedor, int.Parse(metroComboBoxNOMBREPRODUCTOR.SelectedValue.ToString()));
                            }
                            

                           


                            MessageBox.Show("El Proveedor con Cuenta Corriente fue creado Satisfactoriamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroCheckCUENTACORRIENTE.Checked = false;
                            metroCheckBoxPRODUCTOR.Checked = false;


                        }
                        else
                        {

                            //Insertar en la tabla proveedores
                            Model.Proveedores prov = new Model.Proveedores();
                            prov.Nombre = metroTextBoxNOMBRE.Text;
                            prov.Razon = metroTextBoxRAZON.Text;
                            prov.Cuit = metroTextBoxCUIT.Text;
                            prov.FechaIngreso = metroDateTimeFECHA.Value;
                            prov.IngresosBrutos = metroTextBoxIIBB.Text;
                            prov.Telefono = metroTextBoxTELEFONO.Text;
                            prov.Direccion = metroTextBoxDIRECCION.Text;
                            prov.IDProvincia = metroComboBoxPROVINCIA.SelectedValue.ToString();
                            prov.IDLocalidad = int.Parse(metroComboBoxLOCALIDAD.SelectedValue.ToString());
                            prov.IDRubro = int.Parse(metroComboBoxRUBROS.SelectedValue.ToString());
                            pm.insertar_proveedor(prov);
                            MessageBox.Show("El Proveedor fue creado Satisfactoriamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }

                    metroTextBoxNOMBRE.Clear();
                    metroTextBoxRAZON.Clear();
                    metroTextBoxCUIT.Clear();
                    metroTextBoxIIBB.Clear();
                    metroTextBoxTELEFONO.Clear();
                    metroTextBoxRAZON.Clear();
                    metroTextBoxDIRECCION.Clear();
                    metroGrid1.Refresh();
                    metroGrid1.DataSource = pm.ListarProveedores();

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
                ProveedorManager pm = new ProveedorManager();


                if (pm.EliminarProveedor(metroGrid1.CurrentRow.Cells["Cuit"].Value.ToString()) == 1)
                {

                    MessageBox.Show("Se ha eliminado Correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroGrid1.DataSource = pm.ListarProveedores();
                }
                else
                {
                    MessageBox.Show("Error Al eliminar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroGrid1.DataSource = pm.ListarProveedores();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            Model.Proveedores p = new Model.Proveedores();
            p = pm.EncontrarProveedor(metroGrid1.CurrentRow.Cells["Cuit"].Value.ToString());

            metroTextBoxNOMBRE.Text = p.Nombre;
            metroTextBoxRAZON.Text = p.Razon;
            metroTextBoxTELEFONO.Text = p.Telefono;
            metroTextBoxDIRECCION.Text = p.Direccion;
            metroTextBoxCUIT.Text = p.Cuit;
            metroTabPage1.Focus();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {

                ProveedorManager pm = new ProveedorManager();


                pm.ActualizarProveedor(metroTextBoxNOMBRE.Text, metroTextBoxRAZON.Text, metroTextBoxTELEFONO.Text, metroTextBoxDIRECCION.Text, metroTextBoxCUIT.Text);

                MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroGrid1.DataSource = pm.ListarProveedores();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
