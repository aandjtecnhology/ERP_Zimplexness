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
    public partial class ProductosServiciosControl : UserControl
    {
        public ProductosServiciosControl()
        {
            InitializeComponent();
        }
        public int idarticuloupdate { get; set; }

        private void ArticuloServiciosControl_Load(object sender, EventArgs e)
        {
            ArticuloManager a = new ArticuloManager();
            dataGridViewArticulos.DataSource = a.ListarArticulos();
            comboBoxCategoria.DataSource = a.Categorias();
            comboBoxCategoria.DisplayMember = "Categoria";
            comboBoxCategoria.ValueMember = "IDCategoria";



            comboBoxUbicacion.DataSource = a.ListarUbicacion();
            comboBoxUbicacion.DisplayMember = "Ubicacion1";
            comboBoxUbicacion.ValueMember = "IdUbicacion";

            

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNombre.Text) == true)
                {
                    MessageBox.Show("Debe insertar al menos el nombre del articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                else
                {
                    ArticuloManager a = new ArticuloManager();

                    if (a.ValidateArticulo(textBoxNombre.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un articulo con el mismo nombre", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        a.InsertarArticulos(int.Parse(comboBoxCategoria.SelectedValue.ToString()), int.Parse(comboBoxUbicacion.SelectedValue.ToString()),
                                            textBoxNombre.Text, textBoxDescripcion.Text, textBoxCodigo.Text,
                                            float.Parse(textBoxIva.Text.Replace(".", ",")));

                        MessageBox.Show("El articulo se ingreso con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewArticulos.DataSource = new ArticuloManager().ListarArticulos();
                        textBoxNombre.Clear();
                        textBoxDescripcion.Clear();
                        textBoxCodigo.Clear();
                        textBoxIva.Clear();
                        textBoxNombre.Focus();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBoxfiltro_TextChanged_1(object sender, EventArgs e)
        {


        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                ArticuloManager a = new ArticuloManager();
                a.ActualizarArticulos(idarticuloupdate, textBoxNombre.Text, int.Parse(comboBoxUbicacion.SelectedValue.ToString()), textBoxDescripcion.Text, textBoxCodigo.Text);
                MessageBox.Show("El Articulo se actualizo con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("No se Pudo Actualizar");
                throw;
            }
        }

       

        private void button3_Click_2(object sender, EventArgs e)
        {
            ArticuloManager a = new ArticuloManager();
            Model.Articulos art = new Model.Articulos();
            art = a.EncontrarArticulo(int.Parse(dataGridViewArticulos.CurrentRow.Cells["IDArticulo"].Value.ToString()));

            textBoxNombre.Text = art.Nombre;
            textBoxDescripcion.Text = art.Descripcion;
            textBoxCodigo.Text = art.Codigo;
            idarticuloupdate = art.IDArticulo;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                ArticuloManager artmanager = new ArticuloManager();
                int idarticulo = int.Parse(dataGridViewArticulos.CurrentRow.Cells["IDArticulo"].Value.ToString());

                if (artmanager.EliminarArticulo(idarticulo) == 1)
                {
                    MessageBox.Show("El Articulo se elimino con exito");
                    dataGridViewArticulos.DataSource = artmanager.ListarArticulos();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void textBoxfiltro_TextChanged(object sender, EventArgs e)
        {
            ArticuloManager artmanager = new ArticuloManager();
            dataGridViewArticulos.DataSource = artmanager.FiltrarArticulos(textBoxfiltro.Text);
        }
    }
}

