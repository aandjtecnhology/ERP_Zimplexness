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
    public partial class MetroProductos : UserControl
    {
        public MetroProductos()
        {
            InitializeComponent();
        }
        public int idarticuloupdate { get; set; }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroProductos_Load(object sender, EventArgs e)
        {
            ArticuloManager a = new ArticuloManager();
            metroGridProductos.DataSource = a.ListarArticulos();
            metroComboBoxCategoria.DataSource = a.Categorias();
            metroComboBoxCategoria.DisplayMember = "Categoria";
            metroComboBoxCategoria.ValueMember = "IDCategoria";



            metroComboBoxUbicacion.DataSource = a.ListarUbicacion();
            metroComboBoxUbicacion.DisplayMember = "Ubicacion1";
            metroComboBoxUbicacion.ValueMember = "IdUbicacion";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxProducto.Text) == true)
                {
                    MessageBox.Show("Debe insertar al menos el nombre del articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                else
                {
                    ArticuloManager a = new ArticuloManager();

                    if (a.ValidateArticulo(metroTextBoxProducto.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un articulo con el mismo nombre", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        a.InsertarArticulos(int.Parse(metroComboBoxCategoria.SelectedValue.ToString()), int.Parse(metroComboBoxUbicacion.SelectedValue.ToString()),
                                            metroTextBoxProducto.Text, metroTextBoxDescripcion.Text, metroTextBoxCodigo.Text,
                                            float.Parse(metroTextBoxIva.Text.Replace(".", ",")));

                        MessageBox.Show("El articulo se ingreso con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGridProductos.DataSource = new ArticuloManager().ListarArticulos();
                        metroTextBoxProducto.Clear();
                        metroTextBoxDescripcion.Clear();
                        metroTextBoxCodigo.Clear();
                        metroTextBoxIva.Clear();
                        metroTextBoxProducto.Focus();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTextBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            ArticuloManager artmanager = new ArticuloManager();
            metroGridProductos.DataSource = artmanager.FiltrarArticulos(metroTextBoxFiltroNombre .Text);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ArticuloManager a = new ArticuloManager();
            Model.Articulos art = new Model.Articulos();
            art = a.EncontrarArticulo(int.Parse(metroGridProductos.CurrentRow.Cells["IDArticulo"].Value.ToString()));

            metroTextBoxProducto.Text = art.Nombre;
            metroTextBoxDescripcion.Text = art.Descripcion;
            metroTextBoxCodigo.Text = art.Codigo;
            idarticuloupdate = art.IDArticulo;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                ArticuloManager artmanager = new ArticuloManager();
                int idarticulo = int.Parse(metroGridProductos.CurrentRow.Cells["IDArticulo"].Value.ToString());

                if (artmanager.EliminarArticulo(idarticulo) == 1)
                {
                    MessageBox.Show("El Articulo se elimino con exito");
                    metroGridProductos.DataSource = artmanager.ListarArticulos();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
