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
    public partial class IngresoMaterialesControl : UserControl
    {
        public IngresoMaterialesControl()
        {
            InitializeComponent();
        }

        private void IngresoMaterialesControl_Load(object sender, EventArgs e)
        {
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

            Clases.EmpleadoManager Empleado = new Clases.EmpleadoManager();
            Clases.AlmacenManager Almacenm = new Clases.AlmacenManager();
            comboBoxEncargado.DataSource = Empleado.ListarEmpleados();
            comboBoxEncargado.DisplayMember = "Nombres";
            comboBoxEncargado.ValueMember = "IDEmpleado";



        }
    }
}
