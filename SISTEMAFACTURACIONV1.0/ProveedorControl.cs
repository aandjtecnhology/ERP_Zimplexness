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
    public partial class ProveedorControl : UserControl
    {
        public ProveedorControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void ProveedorControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Provincia_localidad PLmanager = new Provincia_localidad();
            comboBoxProvincia.DataSource = PLmanager.ListarProvincias();
            comboBoxLocalidad.DataSource = PLmanager.ListarLocalidades();

            comboBoxProvincia.DisplayMember = "Provincias";
            comboBoxProvincia.ValueMember = "IDProvincias";

            comboBoxLocalidad.DisplayMember = "Localidades";
            comboBoxLocalidad.ValueMember = "IdLocalidad";

            dataGridView1.DataSource = new ProveedorManager().ListarProveedores();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                ProveedorManager pm = new ProveedorManager();


                pm.ActualizarProveedor(textBoxNombre.Text, textBoxRazon.Text, textBoxTelefono.Text, textBoxDireccion.Text, textBoxCuit.Text);

                MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();


            if (pm.EliminarProveedor(dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString()) == 1)
            {

                MessageBox.Show("Se ha eliminado Correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();
            }
            else
            {
                MessageBox.Show("Error Al eliminar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();
            }


        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            DataModel.Table_Proveedores p = new DataModel.Table_Proveedores();
            p = pm.EncontrarProveedor(dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString());

            textBoxNombre.Text = p.Nombre;
            textBoxRazon.Text = p.Razon;
            textBoxTelefono.Text = p.Telefono;
            textBoxDireccion.Text = p.Direccion;
            textBoxCuit.Text = p.Cuit;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxCuit.Text) || string.IsNullOrEmpty(textBoxRazon.Text))
                {
                    MessageBox.Show("Debe insertar al menos el Nombre, Razon y CUIT", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProveedorManager pm = new ProveedorManager();
                    CuentaCorrienteManager c = new CuentaCorrienteManager();
                    if (pm.ValidateProveedor(textBoxCuit.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un proveedor con el mismo CUIT", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (c.ValidateCuentaCorriente(textBoxCuit.Text) == 1)
                        {
                            MessageBox.Show("Ya existe un Proveedor con ese nombre de cuenta corriente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {


                            DataModel.Table_Proveedores prov = new DataModel.Table_Proveedores();

                            prov.Nombre = textBoxNombre.Text;
                            prov.Razon = textBoxRazon.Text;
                            prov.Cuit = textBoxCuit.Text;
                            prov.FechaIngreso = Convert.ToDateTime(maskedTextBoxFecha.Text);
                            prov.IngresosBrutos = textBoxIngresosBrutos.Text;
                            prov.Telefono = textBoxTelefono.Text;
                            prov.Direccion = textBoxDireccion.Text;
                            prov.IDProvincia = comboBoxProvincia.SelectedValue.ToString();
                            prov.IDLocalidad = comboBoxLocalidad.SelectedValue.ToString();


                            pm.insertar_proveedor(prov);
                            MessageBox.Show("EL proveedor se ha insertado correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (CheckboxCuentaCorriente.Checked == true)
                            {
                                if (pm.ValidateCuentaCorriente(textBoxCuit.Text) == 1)
                                {
                                    MessageBox.Show("Ya existe este proveedor con cuenta corriente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    DataModel.Table_CuentaCorriente cuenta = new DataModel.Table_CuentaCorriente();
                                    cuenta.Nombre = textBoxCuit.Text;
                                    cuenta.Vencimiento = int.Parse(comboBoxVencimiento.Text);
                                    cuenta.IDProveedor = pm.devolverIDProveedorCUIT(textBoxCuit.Text);

                                    pm.CrearCuentaCorriente(cuenta);

                                }
                            }

                            textBoxNombre.Clear();
                            textBoxRazon.Clear();
                            textBoxCuit.Clear();
                            textBoxIngresosBrutos.Clear();
                            textBoxTelefono.Clear();
                            textBoxDireccion.Clear();
                            dataGridView1.Refresh();
                            dataGridView1.DataSource = pm.ListarProveedores();

                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {

                ProveedorManager pm = new ProveedorManager();


                pm.ActualizarProveedor(textBoxNombre.Text, textBoxRazon.Text, textBoxTelefono.Text, textBoxDireccion.Text, textBoxCuit.Text);

                MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();


            if (pm.EliminarProveedor(dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString()) == 1)
            {

                MessageBox.Show("Se ha eliminado Correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();
            }
            else
            {
                MessageBox.Show("Error Al eliminar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();
            }
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            DataModel.Table_Proveedores p = new DataModel.Table_Proveedores();
            p = pm.EncontrarProveedor(dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString());

            textBoxNombre.Text = p.Nombre;
            textBoxRazon.Text = p.Razon;
            textBoxTelefono.Text = p.Telefono;
            textBoxDireccion.Text = p.Direccion;
            textBoxCuit.Text = p.Cuit;
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            dataGridView1.DataSource = pm.filtrarproveedores(textBoxFiltro.Text);
        }

        private void textBoxFiltroRazon_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            dataGridView1.DataSource = pm.filtrarproveedoresRazon(textBoxFiltroRazon.Text);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxCuit.Text) || string.IsNullOrEmpty(textBoxRazon.Text))
                {
                    MessageBox.Show("Debe insertar al menos el Nombre, Razon y CUIT", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProveedorManager pm = new ProveedorManager();
                    CuentaCorrienteManager c = new CuentaCorrienteManager();
                    if (pm.ValidateProveedor(textBoxCuit.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un proveedor con el mismo CUIT", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (c.ValidateCuentaCorriente(textBoxCuit.Text) == 1)
                        {
                            MessageBox.Show("Ya existe un Proveedor con ese nombre de cuenta corriente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {


                            DataModel.Table_Proveedores prov = new DataModel.Table_Proveedores();

                            prov.Nombre = textBoxNombre.Text;
                            prov.Razon = textBoxRazon.Text;
                            prov.Cuit = textBoxCuit.Text;
                            prov.FechaIngreso = Convert.ToDateTime(maskedTextBoxFecha.Text);
                            prov.IngresosBrutos = textBoxIngresosBrutos.Text;
                            prov.Telefono = textBoxTelefono.Text;
                            prov.Direccion = textBoxDireccion.Text;
                            prov.IDProvincia = comboBoxProvincia.SelectedValue.ToString();
                            prov.IDLocalidad = comboBoxLocalidad.SelectedValue.ToString();


                            pm.insertar_proveedor(prov);
                            MessageBox.Show("EL proveedor se ha insertado correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (CheckboxCuentaCorriente.Checked == true)
                            {
                                if (pm.ValidateCuentaCorriente(textBoxCuit.Text) == 1)
                                {
                                    MessageBox.Show("Ya existe este proveedor con cuenta corriente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    DataModel.Table_CuentaCorriente cuenta = new DataModel.Table_CuentaCorriente();
                                    cuenta.Nombre = textBoxCuit.Text;
                                    cuenta.Vencimiento = int.Parse(comboBoxVencimiento.Text);
                                    cuenta.IDProveedor = pm.devolverIDProveedorCUIT(textBoxCuit.Text);

                                    pm.CrearCuentaCorriente(cuenta);

                                }
                            }

                            textBoxNombre.Clear();
                            textBoxRazon.Clear();
                            textBoxCuit.Clear();
                            textBoxIngresosBrutos.Clear();
                            textBoxTelefono.Clear();
                            textBoxDireccion.Clear();
                            dataGridView1.Refresh();
                            dataGridView1.DataSource = pm.ListarProveedores();

                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonActualizar_Click_2(object sender, EventArgs e)
        {
            try
            {

                ProveedorManager pm = new ProveedorManager();


                pm.ActualizarProveedor(textBoxNombre.Text, textBoxRazon.Text, textBoxTelefono.Text, textBoxDireccion.Text, textBoxCuit.Text);

                MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxCuit.Text) || string.IsNullOrEmpty(textBoxRazon.Text))
                {
                    MessageBox.Show("Debe insertar al menos el Nombre, Razon y CUIT", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProveedorManager pm = new ProveedorManager();
                    CuentaCorrienteManager c = new CuentaCorrienteManager();
                    if (pm.ValidateProveedor(textBoxCuit.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un proveedor con el mismo CUIT", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (c.ValidateCuentaCorriente(textBoxCuit.Text) == 1)
                        {
                            MessageBox.Show("Ya existe un Proveedor con ese nombre de cuenta corriente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {


                            DataModel.Table_Proveedores prov = new DataModel.Table_Proveedores();

                            prov.Nombre = textBoxNombre.Text;
                            prov.Razon = textBoxRazon.Text;
                            prov.Cuit = textBoxCuit.Text;
                            prov.FechaIngreso = Convert.ToDateTime(maskedTextBoxFecha.Text);
                            prov.IngresosBrutos = textBoxIngresosBrutos.Text;
                            prov.Telefono = textBoxTelefono.Text;
                            prov.Direccion = textBoxDireccion.Text;
                            prov.IDProvincia = comboBoxProvincia.SelectedValue.ToString();
                            prov.IDLocalidad = comboBoxLocalidad.SelectedValue.ToString();


                            pm.insertar_proveedor(prov);
                            MessageBox.Show("EL proveedor se ha insertado correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (CheckboxCuentaCorriente.Checked == true)
                            {
                                if (pm.ValidateCuentaCorriente(textBoxCuit.Text) == 1)
                                {
                                    MessageBox.Show("Ya existe este proveedor con cuenta corriente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    DataModel.Table_CuentaCorriente cuenta = new DataModel.Table_CuentaCorriente();
                                    cuenta.Nombre = textBoxCuit.Text;
                                    cuenta.Vencimiento = int.Parse(comboBoxVencimiento.Text);
                                    cuenta.IDProveedor = pm.devolverIDProveedorCUIT(textBoxCuit.Text);

                                    pm.CrearCuentaCorriente(cuenta);

                                }
                            }

                            textBoxNombre.Clear();
                            textBoxRazon.Clear();
                            textBoxCuit.Clear();
                            textBoxIngresosBrutos.Clear();
                            textBoxTelefono.Clear();
                            textBoxDireccion.Clear();
                            dataGridView1.Refresh();
                            dataGridView1.DataSource = pm.ListarProveedores();

                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonActualizar_Click_3(object sender, EventArgs e)
        {
            try
            {

                ProveedorManager pm = new ProveedorManager();


                pm.ActualizarProveedor(textBoxNombre.Text, textBoxRazon.Text, textBoxTelefono.Text, textBoxDireccion.Text, textBoxCuit.Text);

                MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = pm.ListarProveedores();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            try
            {
                ProveedorManager pm = new ProveedorManager();


                if (pm.EliminarProveedor(dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString()) == 1)
                {

                    MessageBox.Show("Se ha eliminado Correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = pm.ListarProveedores();
                }
                else
                {
                    MessageBox.Show("Error Al eliminar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = pm.ListarProveedores();
                }

            }
            catch (Exception)
            {

                throw;
            }

                
           }
        private void buttonEditar_Click_2(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            DataModel.Table_Proveedores p = new DataModel.Table_Proveedores();
            p = pm.EncontrarProveedor(dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString());

            textBoxNombre.Text = p.Nombre;
            textBoxRazon.Text = p.Razon;
            textBoxTelefono.Text = p.Telefono;
            textBoxDireccion.Text = p.Direccion;
            textBoxCuit.Text = p.Cuit;
        }

        private void textBoxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            dataGridView1.DataSource = pm.filtrarproveedores(textBoxFiltro.Text);
        }

        private void textBoxFiltroRazon_TextChanged_1(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            dataGridView1.DataSource = pm.filtrarproveedoresRazon(textBoxFiltroRazon.Text);
        }

        private void textBoxCuit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
