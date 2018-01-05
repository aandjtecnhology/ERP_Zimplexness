using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class LocalidadProvinciaFRM : Form
    {
        public LocalidadProvinciaFRM()
        {
            InitializeComponent();
        }
        private Provincia_localidad Localidad_Provincia;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxLocalidad.Text) == true || string.IsNullOrEmpty(textBoxCP.Text)==true)
                {
                    MessageBox.Show("Error, debe insertar la localidad y el codigo postal","Sistema Gestion de Compras",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else
                {
                    Localidad_Provincia= new Provincia_localidad();
                    Localidad_Provincia.InsertarLocalidad(textBoxLocalidad.Text,textBoxCP.Text);
                    MessageBox.Show("Se ha insertado con exito", "Sistema Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LocalidadProvinciaFRM_Load(object sender, EventArgs e)
        {
            //Llenar el datagridlocalid

            Localidad_Provincia = new Provincia_localidad();
            dataGridViewLocalidad.DataSource = Localidad_Provincia.ListarLocalidades();

            //llenar DatagridProvincia
            dataGridViewProvincia.DataSource = Localidad_Provincia.ListarProvincias();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
