using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Xml.Linq;
using System.Net;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class MetroEmpleado : UserControl
    {
        public MetroEmpleado()
        {
            InitializeComponent();
        }

        

        private void ComprobanteControl_Load(object sender, EventArgs e)
        {

            Clases.EmpleadosManager objectempleado=new Clases.EmpleadosManager();

            metroComboBoxDepartamento.DataSource = objectempleado.ListarDepartamentos();
            metroComboBoxDepartamento.DisplayMember = "Descripcion";
            metroComboBoxDepartamento.ValueMember = "IdDepartamento";

            metroComboBoxNombreEmpleado.DataSource = objectempleado.ListarSolicitudesEmpleo();
            metroComboBoxNombreEmpleado.DisplayMember = "nombrepersona";
            metroComboBoxNombreEmpleado.ValueMember = "IdPersona";

            metroComboBoxSindicato.DataSource = objectempleado.ListarSindicatos();
            metroComboBoxSindicato.DisplayMember = "Descripcion";
            metroComboBoxSindicato.ValueMember = "idSindicato";

            metroComboBoxEspecialidad.DataSource = objectempleado.ListarEspecialidades();
            metroComboBoxEspecialidad.DisplayMember = "Descripcion";
            metroComboBoxEspecialidad.ValueMember = "idEspecialidad";

            metroComboBoxCategoria.DataSource = objectempleado.ListarCategoriaEmpleado();
            metroComboBoxCategoria.DisplayMember = "Descripcion";
            metroComboBoxCategoria.ValueMember = "idCategoriaEmpleado";

            metroComboBoxZona.DataSource = new Clases.Zonas().ListarZonas();
            metroComboBoxZona.DisplayMember = "Zonas1";
            metroComboBoxZona.ValueMember = "idZona";

            metroComboBoxAfectado.DataSource = new Clases.Afectado_a_Cliente().ListarEmpresasClientes();
            metroComboBoxAfectado.DisplayMember = "Nombre";
            metroComboBoxAfectado.ValueMember = "IDEmpresaCliente";

            //llenar datagrid empleados




            List<Model.DatosEmpleadosActivos> empleadosactivos = objectempleado.ListarEmpleadosActivos();

            metroGridEmpleadosActivos.AutoGenerateColumns = false;
            metroGridEmpleadosActivos.DataSource = empleadosactivos;
            metroGridEmpleadosActivos.AutoSize = false;

            foreach (var item in empleadosactivos)
            {
                IdEmpleado1.DataPropertyName = "IDEmpleado";
                Imagen.DataPropertyName = "ImagenPerfil";
                legajo.DataPropertyName = "NoLegajo";
                Nombre.DataPropertyName = "Nombre";
                Apellidos.DataPropertyName = "Apellido";
                DNI.DataPropertyName = "DNI";
                CUIL.DataPropertyName = "CUIL";
                FechaNacimiento.DataPropertyName = "FechaNacimiento";
                Sexo.DataPropertyName = "Sexo";
                EstadoCivil.DataPropertyName = "EstadoCivil";
                Nacionalidad.DataPropertyName = "Nacionalidad";
                Direccion.DataPropertyName = "Domicilio";
                Localidad.DataPropertyName = "Localidades";
                CP.DataPropertyName = "CodigoPostal";
                Departamento.DataPropertyName = "Descripcion";
                CategoriaEmpleado.DataPropertyName = "CategoriaEmpleado1";
                Activo.DataPropertyName = "Activo";

            }


            DataGridViewRow row = metroGridEmpleadosActivos.CurrentRow;




           
            if (row == null)
                return;

            DataGridViewImageCell cell = row.Cells["Imagen"] as DataGridViewImageCell;
            byte[] imagen = (byte[])cell.Value;
            metroTextBoxNoLegajo.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Legajo"].Value.ToString();
            pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(imagen));
            metroTextBoxNombre.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Nombre"].Value.ToString();
            metroTextBoxApellidos.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Apellidos"].Value.ToString(); ;
            metroTextBoxDNI.Text = metroGridEmpleadosActivos.CurrentRow.Cells["DNI"].Value.ToString();
            metroTextBoxCUIL.Text = metroGridEmpleadosActivos.CurrentRow.Cells["CUIL"].Value.ToString();
            metroTextBoxDireccion.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Direccion"].Value.ToString();
            metroTextBoxNacionalidad.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Nacionalidad"].Value.ToString();
            metroTextBoxLocalidad.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Localidad"].Value.ToString();


            //geolocalizacion

            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("http://maps.google.com/maps?q=");
                queryadress.Append(metroGridEmpleadosActivos.CurrentRow.Cells["Direccion"].Value.ToString()+"");
                webBrowser1.Navigate(queryadress.ToString());

            }
            catch (Exception)
            {

                throw;
            }
            




        }

        private void buttonCancelarComprobante_Click_1(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_Leave_1(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBox2_Leave_1(object sender, EventArgs e)
        {
            
        }

        private void dateTimePickerFecha_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBoxPrecioCompra_KeyDown_1(object sender, KeyEventArgs e)
        {
          
        }

        private void buttonAgregar1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonEliminarArticulo_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int idempleado = 0;
                Clases.EmpleadosManager OEmpleado = new Clases.EmpleadosManager();

                if (string.IsNullOrEmpty(metroTextBoxLegajo.Text) == true|| string.IsNullOrEmpty(metroComboBoxNombreEmpleado.Text) == true)
                {
                    MessageBox.Show("Error,debe insertar el numero de legajo y el nombre","Sistema de Gestion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (OEmpleado.DevolverNolegajo(int.Parse(metroComboBoxNombreEmpleado.SelectedValue.ToString()), metroTextBoxLegajo.Text) == 0)
                    {
                        MessageBox.Show("Error, no debe insertar 2 empleados con el mismo numero de legajo", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else
                    {


                        bool value1, value2;
                        //obtener valor activo e ieric
                        //valor de Empleado Activo
                        if (metroCheckBoxActivo.Checked == true)
                        {
                            value1 = true;

                        }
                        else
                        {
                            value1 = false;
                        }
                        //valor de ieric activo
                        if (metroCheckIEric.Checked == true)
                        {
                            value2 = true;
                        }
                        else
                        {
                            value2 = false;
                        }


                         idempleado= OEmpleado.InsertarEmpleadoBasico(metroTextBoxLegajo.Text, int.Parse(metroComboBoxNombreEmpleado.SelectedValue.ToString()), int.Parse(metroComboBoxDepartamento.SelectedValue.ToString()), int.Parse(metroComboBoxSindicato.SelectedValue.ToString()), metroDateTimeFECHAIngreso.Value, int.Parse(metroComboBoxEspecialidad.SelectedValue.ToString()), int.Parse(metroComboBoxCategoria.SelectedValue.ToString()),  value1, value2, metroTextBoxComentario.Text);
                        //insertar en la tabla empresas clientes


                        if (metroGridAfectado.Rows.Count == 0)
                        {
                            MessageBox.Show("Error Debe Insertar la empresa a la cual esta afectado el empleado", "Erp Zimplexness", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Clases.Afectado_a_Cliente ObjectAfectado=new Clases.Afectado_a_Cliente();

                            foreach (DataGridViewRow row1 in metroGridAfectado.Rows)
                            {
                                ObjectAfectado.InsertarEmpleadoAfectadoCliente(idempleado,int.Parse(row1.Cells["ID"].Value.ToString()));
                                


                            }

                        }



                        MessageBox.Show("Se ha ingresado con exito el empleado", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        metroTextBoxLegajo.Clear();
                        metroTextBoxComentario.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGridEmpleadosActivos_Click(object sender, EventArgs e)
        {






            DataGridViewRow row = metroGridEmpleadosActivos.CurrentRow;





            if (row == null)
                return;

            DataGridViewImageCell cell = row.Cells["Imagen"] as DataGridViewImageCell;
            byte[] imagen = (byte[])cell.Value;
            metroTextBoxNoLegajo.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Legajo"].Value.ToString();
            pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(imagen));
            metroTextBoxNombre.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Nombre"].Value.ToString();
            metroTextBoxApellidos.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Apellidos"].Value.ToString(); ;
            metroTextBoxDNI.Text = metroGridEmpleadosActivos.CurrentRow.Cells["DNI"].Value.ToString();
            metroTextBoxCUIL.Text = metroGridEmpleadosActivos.CurrentRow.Cells["CUIL"].Value.ToString();
            metroTextBoxDireccion.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Direccion"].Value.ToString();
            metroTextBoxNacionalidad.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Nacionalidad"].Value.ToString();
            metroTextBoxLocalidad.Text = metroGridEmpleadosActivos.CurrentRow.Cells["Localidad"].Value.ToString();

            string direccion, localidad, pais;
            direccion = metroGridEmpleadosActivos.CurrentRow.Cells["Direccion"].Value.ToString();
            localidad = metroGridEmpleadosActivos.CurrentRow.Cells["Localidad"].Value.ToString();
            pais = "Buenos Aires,Argentina";

            try
            {
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("http://maps.google.com/maps?q=");
                queryadress.Append(metroGridEmpleadosActivos.CurrentRow.Cells["Direccion"].Value.ToString() + "");
                webBrowser1.Navigate(queryadress.ToString());
                
            }
            catch (Exception)
            {

                throw;
            }






        }

        private void metroGridEmpleadosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //insertar Empresa Cliente
            try
            {
                var empresascliente = new string[] {metroComboBoxAfectado.SelectedValue.ToString(), metroComboBoxAfectado.Text };
                metroGridAfectado.Rows.Add(empresascliente);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void metroGridAfectado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
