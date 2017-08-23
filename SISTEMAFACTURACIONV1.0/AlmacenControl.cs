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
    public partial class AlmacenControl : UserControl
    {
        public AlmacenControl()
        {
            InitializeComponent();
        }

        private void AlmacenControl_Load(object sender, EventArgs e)
        {
            //llenar comboboxEncargados
            Clases.EmpleadoManager Empleado = new Clases.EmpleadoManager();
            Clases.AlmacenManager Almacenm = new Clases.AlmacenManager();
            comboBoxEncargado.DataSource = Empleado.ListarEmpleados();
            comboBoxEncargado.DisplayMember ="Nombres";
            comboBoxEncargado.ValueMember = "IDEmpleado";

            comboBoxZonas.DataSource = Almacenm.ListarZonas();
            comboBoxZonas.DisplayMember = "Zonas";
            comboBoxZonas.ValueMember="IdZona";

            dataGridView1.DataSource = Almacenm.ListarAlamcenes();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.AlmacenManager A = new Clases.AlmacenManager();
                if (string.IsNullOrEmpty(textBoxNombre.Text)==true)
                {
                    MessageBox.Show("Error, Debe Insertar los datos","Sistema Gestion de Compras",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (A.InsertarAlmacen(dateTimePickerFecha.Value, textBoxNombre.Text, textBoxCodigo.Text, int.Parse(comboBoxEncargado.SelectedValue.ToString()), int.Parse(comboBoxZonas.SelectedValue.ToString()))==1)
                    {
                        MessageBox.Show("Se Inserto el Almacen con exito","Sistema de Gestion de Compras",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dataGridView1.DataSource = A.ListarAlamcenes();
                    }
                    ;


                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBoxZonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
