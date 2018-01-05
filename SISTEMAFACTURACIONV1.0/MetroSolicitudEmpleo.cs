using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Configuration;
using System.Net.NetworkInformation;




namespace SISTEMAFACTURACIONV1._0
{
    public partial class MetroSolicitudEmpleo : UserControl
    {
        public MetroSolicitudEmpleo()
        {
            InitializeComponent();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void MetroSolicitudEmpleo_Load(object sender, EventArgs e)
        {
            //cargar todos los combobox


            metroComboBoxNacionalidades.DataSource = new Clases.Nacionalidades().ListarNacionalidades();
            metroComboBoxNacionalidades.DisplayMember = "Nacionalidad";
            metroComboBoxNacionalidades.ValueMember = "IdNacionalidad";


            metroComboBoxLocalidades.DataSource = new Provincia_localidad().ListarLocalidades();
            metroComboBoxLocalidades.DisplayMember = "Localidades1";
            metroComboBoxLocalidades.ValueMember = "IdLocalidad";

            metroComboBoxEstadoCivil.DataSource = new Clases.EstadoCivil().ListarEstadoCivil();
            metroComboBoxEstadoCivil.DisplayMember = "EstadoCivil1";
            metroComboBoxEstadoCivil.ValueMember = "IDEstadoCivil";

            metroComboBoxObraSocial.DataSource = new Clases.ObraSocial().ListarObraSocial();
            metroComboBoxObraSocial.DisplayMember = "Descripcion";
            metroComboBoxObraSocial.ValueMember = "idObraSocial";


            metroComboBoxEstudios.DataSource = new Clases.Estudios().ListarEstudios();
            metroComboBoxEstudios.ValueMember = "IDEstudios";
            metroComboBoxEstudios.DisplayMember = "Descripcion";

            metroComboBoxSexo.DataSource = new Clases.Sexos().ListarSexos();
            metroComboBoxSexo.DisplayMember = "Sexo";
            metroComboBoxSexo.ValueMember = "IDSexo";


            //llenar solicitud empleo
            Clases.SolicitudEmpleo solicitudobj = new Clases.SolicitudEmpleo();

            List<Model.DetallesSolicitudesEmpleo> solicitudempleo = solicitudobj.ListarSolicitudesEmpleo();
            metroGridSolicitudEmpleo.AutoGenerateColumns = false;
            metroGridSolicitudEmpleo.DataSource = solicitudempleo;
            metroGridSolicitudEmpleo.AutoSize = false;

            foreach (var item in solicitudempleo)
            {
                FechaSolicitud.DataPropertyName = "Fecha";
                Nombre.DataPropertyName = "Nombre";
                Apellidos.DataPropertyName = "Apellido";
                Sexo.DataPropertyName = "Sexo";
                DNI.DataPropertyName = "DNI";
                CUIL.DataPropertyName = "CUIL";
                FechaNacimiento.DataPropertyName = "FechaNacimiento";
                Nacionalidad.DataPropertyName = "Nacionalidad";
                Direccion.DataPropertyName = "Domicilio";
                Localidad.DataPropertyName = "localidad";
                CodigoPostal.DataPropertyName = "CodigoPostal";
                Telefono.DataPropertyName = "Telefono";
                Celular.DataPropertyName = "Celular";
                EstadoCivil.DataPropertyName = "EstadoCivil";
                Hijos.DataPropertyName = "Hijos";
                RegistroConducir.DataPropertyName = "RegistroConducir";
                Obrasocial.DataPropertyName = "Obrasocial";
                IERIC.DataPropertyName = "LibretaFondoDesempleo";
                Referencia.DataPropertyName = "AntecedentesLaborales";
                Remuneracion.DataPropertyName = "PretencionRemunerativa";

            }







        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.SolicitudEmpleo solicitudempleo = new Clases.SolicitudEmpleo();
                if (string.IsNullOrEmpty(metroTextBoxNombre.Text)==true|| string.IsNullOrEmpty(metroTextBoxApellidos.Text) == true
                    || string.IsNullOrEmpty(metroTextBoxDNI.Text) == true|| string.IsNullOrEmpty(metroTextBoxCUIL.Text) == true

                    )
                {

                    MessageBox.Show("Error debe Insertar los Datos","Sistema de Gestion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (solicitudempleo.DevolverDNI_CUIL(metroTextBoxDNI.Text, metroTextBoxCUIL.Text) == 1)
                    {
                        MessageBox.Show("Error, ya existe una solicitud con el mismo DNI o CUIL", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        //declaro los objetos a usar
                        Model.Entities Context;
                        Model.Personas solicitud = new Model.Personas();
                        Model.SolicitudesEmpleo object_solicitudempleo = new Model.SolicitudesEmpleo();

                        Boolean LIBRETA = false;
                        Boolean registro = false;
                        //checkear registro de conducir
                        if (metroREgistro.Checked==true)
                        {
                            registro = true;

                        }
                        else
                        {
                            registro = false;
                        }
                        //check libreta fondo de desempleo
                        if (metroCheckBoxLIBRETA.Checked == true)
                        {
                            LIBRETA = true;

                        }
                        else
                        {
                            if (metroCheckBoxLIBRETA.Checked == false)
                            {
                                LIBRETA = false;
                            }

                        }



                        using (Context = new Model.Entities())
                        {
                            int idperson = 0;
                            // Stream usado como buffer
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            // Se extraen los bytes del buffer para asignarlos como valor para el 
                            // parámetro.
                            solicitud.ImagenPerfil = ms.GetBuffer();
                            solicitud.Nombre = metroTextBoxNombre.Text;
                            solicitud.Apellido = metroTextBoxApellidos.Text;
                            solicitud.DNI = metroTextBoxDNI.Text;
                            solicitud.CUIL = metroTextBoxCUIL.Text;
                            solicitud.FechaNacimiento = metroDateTimeNacimiento.Value;
                            solicitud.Telefono = metroTextBoxTelefono.Text;
                            solicitud.Celular = metroTextBoxCelular.Text;
                            solicitud.Domicilio = metroTextBoxDireccion.Text;
                            solicitud.IdLocalidad = int.Parse(metroComboBoxLocalidades.SelectedValue.ToString());
                            solicitud.idObraSocial = int.Parse(metroComboBoxObraSocial.SelectedValue.ToString());
                            solicitud.Hijos = int.Parse(metroTextBoxHijos.Text);
                            solicitud.EstadoCivil = int.Parse(metroComboBoxEstadoCivil.SelectedValue.ToString());
                            solicitud.IdNacionalidad = int.Parse(metroComboBoxNacionalidades.SelectedValue.ToString());
                            solicitud.IdSexo = int.Parse(metroComboBoxSexo.SelectedValue.ToString());
                            solicitud.LibretaFondoDesempleo = LIBRETA;
                            solicitud.RegistroConducir = registro;
                            Context.Personas.Add(solicitud);
                            Context.SaveChanges();
                            idperson = solicitud.IdPersona;
                            object_solicitudempleo.Fecha = metroFechaSolicitud.Value;
                            object_solicitudempleo.idPersona = idperson;
                            object_solicitudempleo.AntecedentesLaborales = metroTextBoxAnteLAborales.Text;
                            object_solicitudempleo.PretencionRemunerativa =float.Parse( metroTextBoxRemuneracion.Text);
                            Context.SolicitudesEmpleo.Add(object_solicitudempleo);
                            Context.SaveChanges();

                            //borrar datos de la solicitud de empleo    
                            metroTextBoxNombre.Clear();
                            metroTextBoxApellidos.Clear();
                            metroTextBoxDNI.Clear();
                            metroTextBoxCUIL.Clear();
                            metroTextBoxTelefono.Clear();
                            metroTextBoxCelular.Clear();
                            metroTextBoxHijos.Clear();
                            metroTextBoxAnteLAborales.Clear();
                            metroTextBoxRemuneracion.Clear();
                            metroCheckBoxLIBRETA.Checked = false;
                            metroREgistro.Checked = false;


                            MessageBox.Show("SE HA INSERTADO CON EXITO", "SISTEMA DE GESTION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

          
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxReferencias.Text)==true|| string.IsNullOrEmpty(metroTextBoxRefTelefono.Text) == true)
                {

                    MessageBox.Show("Error Debe Insertar los datos", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {



                    string referencia = metroTextBoxReferencias.Text;
                    string telefono = metroTextBoxRefTelefono.Text;   
                        
                        var listareferencia = new String[] { referencia,telefono};
                        metroGridReferencias.Rows.Add(listareferencia);
                        metroTextBoxReferencias.Clear();
                        

                    

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
               
                    string estudios = metroComboBoxEstudios.SelectedText.ToString();


                    var listarestudios = new String[] { estudios};
                    metroGridEstudios.Rows.Add(listarestudios);
           




                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFiltroApellido_TextChanged(object sender, EventArgs e)
        {
            Clases.SolicitudEmpleo pm = new Clases.SolicitudEmpleo();
            metroGridSolicitudEmpleo.DataSource = pm.filtrarsolicitudespornombre(metroTextBoxFiltroApellido.Text);
        }

        private void metroTextBoxFiltroApellido_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFiltroCUIL_TextChanged(object sender, EventArgs e)
        {
            Clases.SolicitudEmpleo pm = new Clases.SolicitudEmpleo();
            metroGridSolicitudEmpleo.DataSource = pm.filtrarsolicitudesporcuil(metroTextBoxFiltroCUIL.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {

            Clases.SolicitudEmpleo solicitud = new Clases.SolicitudEmpleo();
            if (metroGridSolicitudEmpleo.Rows.Count == 0)
            {
                MessageBox.Show("Error, no tiene solicitud empleo para eliminar", "ERP Zimplexness", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                solicitud.EliminarSolicitudEmpleo(metroGridSolicitudEmpleo.CurrentRow.Cells["CUIL"].Value.ToString());
                MessageBox.Show("Se ha eliminado con exito la solicitud de empleo", "ERP Zimplexness", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clases.SolicitudEmpleo solicitudobj = new Clases.SolicitudEmpleo();
                List<Model.DetallesSolicitudesEmpleo> solicitudempleo = solicitudobj.ListarSolicitudesEmpleo();
                metroGridSolicitudEmpleo.AutoGenerateColumns = false;
                metroGridSolicitudEmpleo.DataSource = solicitudempleo;
                metroGridSolicitudEmpleo.AutoSize = false;

                foreach (var item in solicitudempleo)
                {
                    FechaSolicitud.DataPropertyName = "Fecha";
                    Nombre.DataPropertyName = "Nombre";
                    Apellidos.DataPropertyName = "Apellido";
                    Sexo.DataPropertyName = "Sexo";
                    DNI.DataPropertyName = "DNI";
                    CUIL.DataPropertyName = "CUIL";
                    FechaNacimiento.DataPropertyName = "FechaNacimiento";
                    Nacionalidad.DataPropertyName = "Nacionalidad";
                    Direccion.DataPropertyName = "Domicilio";
                    Localidad.DataPropertyName = "localidad";
                    CodigoPostal.DataPropertyName = "CodigoPostal";
                    Telefono.DataPropertyName = "Telefono";
                    Celular.DataPropertyName = "Celular";
                    EstadoCivil.DataPropertyName = "EstadoCivil";
                    Hijos.DataPropertyName = "Hijos";
                    RegistroConducir.DataPropertyName = "RegistroConducir";
                    Obrasocial.DataPropertyName = "Obrasocial";
                    IERIC.DataPropertyName = "LibretaFondoDesempleo";
                    Referencia.DataPropertyName = "AntecedentesLaborales";
                    Remuneracion.DataPropertyName = "PretencionRemunerativa";

                }




            }


        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            Clases.SolicitudEmpleo solicitudobj = new Clases.SolicitudEmpleo();
            List<Model.DetallesSolicitudesEmpleo> solicitudempleo = solicitudobj.ListarSolicitudesEmpleo();
            metroGridSolicitudEmpleo.AutoGenerateColumns = false;
            metroGridSolicitudEmpleo.DataSource = solicitudempleo;
            metroGridSolicitudEmpleo.AutoSize = false;

            foreach (var item in solicitudempleo)
            {
                FechaSolicitud.DataPropertyName = "Fecha";
                Nombre.DataPropertyName = "Nombre";
                Apellidos.DataPropertyName = "Apellido";
                Sexo.DataPropertyName = "Sexo";
                DNI.DataPropertyName = "DNI";
                CUIL.DataPropertyName = "CUIL";
                FechaNacimiento.DataPropertyName = "FechaNacimiento";
                Nacionalidad.DataPropertyName = "Nacionalidad";
                Direccion.DataPropertyName = "Domicilio";
                Localidad.DataPropertyName = "localidad";
                CodigoPostal.DataPropertyName = "CodigoPostal";
                Telefono.DataPropertyName = "Telefono";
                Celular.DataPropertyName = "Celular";
                EstadoCivil.DataPropertyName = "EstadoCivil";
                Hijos.DataPropertyName = "Hijos";
                RegistroConducir.DataPropertyName = "RegistroConducir";
                Obrasocial.DataPropertyName = "Obrasocial";
                IERIC.DataPropertyName = "LibretaFondoDesempleo";
                Referencia.DataPropertyName = "AntecedentesLaborales";
                Remuneracion.DataPropertyName = "PretencionRemunerativa";

            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
