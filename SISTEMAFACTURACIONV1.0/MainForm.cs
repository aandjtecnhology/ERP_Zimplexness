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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string MyUserName { get; set; }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            ProveedorControl ProvControl = new ProveedorControl();  //creas una instancia del primer control de usuario

            panelMain.Controls.Add(ProvControl);

        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    ComprobanteForm c = new ComprobanteForm();
        //    c.ShowDialog();
          panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            ComprobanteControl CompControl = new ComprobanteControl();  //creas una instancia del primer control de usuario

        panelMain.Controls.Add(CompControl);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            PagoControl Pagocon = new PagoControl();  //creas una instancia del primer control de usuario

            panelMain.Controls.Add(Pagocon);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            CuentaCorrienteControl CuentaControl = new CuentaCorrienteControl();  //creas una instancia del primer control de usuario

            panelMain.Controls.Add(CuentaControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.label4.Text = MyUserName;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            ArticuloServiciosControl ART = new ArticuloServiciosControl();  //creas una instancia del primer control de usuario

            panelMain.Controls.Add(ART);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlamacenbttn_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            AlmacenControl almacencontrol = new AlmacenControl();  //creas una instancia del primer control de usuario

            panelMain.Controls.Add(almacencontrol);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();  //para asegurarte de que el panel este vacio
            IngresoMaterialesControl ingresom = new IngresoMaterialesControl();
            panelMain.Controls.Add(ingresom);
        }
    }
}
