using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

        }
        public UserManager umanager = new UserManager();
        public string MyUserName { get; set; }
        public int IDProfiles { get; set; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //    ComprobanteForm c = new ComprobanteForm();
            //    c.ShowDialog();
            //metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            //MetroEmpleado CompControl = new MetroEmpleado();  //creas una instancia del primer control de usuario

            //metroPanel1.Controls.Add(CompControl);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserManager u = new UserManager();
            metroComboBoxUser.DataSource = u.ListarUsername();
            metroComboBoxUser.DisplayMember = "name";

            //metroLabelUsername.Text = MyUserName;
            this.WindowState = FormWindowState.Maximized;

            //try
            //{
            //    if (IDProfiles==1)
            //    {
            //        ProveedorTile.Enabled = true;
                    

            //    }
            //    else
            //    {
            //        if (IDProfiles==2)
            //        {
            //            SolicitudTile.Enabled = true;
            //            PersonalTile.Enabled = true;

            //        }
            //    }


            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //this.metroPanel1.Controls.Clear();
            //LoginControl login = new LoginControl();
            //this.metroPanel1.Controls.Add(login);

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

           
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
            metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            AlmacenControl almacencontrol = new AlmacenControl();  //creas una instancia del primer control de usuario

            metroPanel1.Controls.Add(almacencontrol);
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
              metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            //ProveedorControl ProvControl = new ProveedorControl();  //creas una instancia del primer control de usuario

            //panelMain.Controls.Add(ProvControl);
            MetroProveedores METROPROVEEDOR = new MetroProveedores();
            metroPanel1.Controls.Add(METROPROVEEDOR);


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //    ComprobanteForm c = new ComprobanteForm();
            //    c.ShowDialog();
            metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            MetroComprobantesControl MetroComprobanteControl = new MetroComprobantesControl();  //creas una instancia del primer control de usuario

            metroPanel1.Controls.Add(MetroComprobanteControl);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            MetroPagoControl Pagocon = new MetroPagoControl();  //creas una instancia del primer control de usuario

            metroPanel1.Controls.Add(Pagocon);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            MetroConsultasComprobantes CuentaControl = new MetroConsultasComprobantes();  //creas una instancia del primer control de usuario

            metroPanel1.Controls.Add(CuentaControl);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            MetroProductos ART = new MetroProductos();  //creas una instancia del primer control de usuario

            metroPanel1.Controls.Add(ART);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();  //para asegurarte de que el panel este vacio
            MetroSolicitudEmpleo solicitudcontrol = new MetroSolicitudEmpleo();  //creas una instancia del primer control de usuario

            metroPanel1.Controls.Add(solicitudcontrol);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();
            MetroEmpleado Empleado = new MetroEmpleado();
            metroPanel1.Controls.Add(Empleado);
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            

          Process.Start("http://www.alfamedicaweb.com.ar:8088/Inicio.aspx?ReturnUrl=%2f");
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.swissmedical.com.ar/smgnewsite/smgart/");
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Process.Start("http://190.183.61.26/");
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            Process.Start("https://cablevision.exactian.solutions/webcont/sections/login.php");
            
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.uocra.net/intranet/boletadeposito/logon.asp");
            
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            Process.Start("http://200.80.211.181:2080/ieric-ui/desktop/");
           
        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.institutoasegurador.com.ar:8082/extranet/pages/web/index.jsf");
            
        }

        private void metroTextBoxContraseña_Click(object sender, EventArgs e)
        {
            metroTextBoxContraseña.Text = "";
            metroTextBoxContraseña.UseSystemPasswordChar = true;
        }

        private void metroTextBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(metroComboBoxUser.Text) == true || string.IsNullOrEmpty(metroTextBoxContraseña.Text) == true)
                {
                    MessageBox.Show("Por Favor Inserte el nombre de Usuario y la Contraseña", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    if (umanager.ValidateUser(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 1)
                    {
                        if (umanager.Profile(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 1)
                        {
                            ProveedorTile.Enabled = true;
                            ComprobanteTile.Enabled = true;
                            PagosTile.Enabled = true;
                            ConsultaComprobanteTile.Enabled = true;
                            ProductoServicioTile.Enabled = true;
                            SolicitudTile.Enabled = true;
                            PersonalTile.Enabled = true;
                            metroPanel1.Controls.Clear();

                        }
                        if (umanager.Profile(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 2)
                        {
                            SolicitudTile.Enabled = true;
                            PersonalTile.Enabled = true;
                            metroPanel1.Controls.Clear();

                        }
                        if (umanager.Profile(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 4)
                        {
                            ProductoServicioTile.Enabled = true;
                            ProveedorTile.Enabled = true;
                            ComprobanteTile.Enabled = true;
                            SolicitudTile.Enabled = true;
                            PersonalTile.Enabled = true;
                            metroPanel1.Controls.Clear();

                        }

                        metroLabelUsername.Text = metroComboBoxUser.Text;
                    }
                    else
                    {

                        //MessageBox.Show("Por favor intentelo otra vez", "Zimplexness", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Refresh();
                    }

                }

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroComboBoxUser.Text) == true || string.IsNullOrEmpty(metroTextBoxContraseña.Text) == true)
            {
                MessageBox.Show("Por Favor Inserte el nombre de Usuario y la Contraseña", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {




                if (umanager.ValidateUser(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 1)
                {

                    if (umanager.Profile(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 1)
                    {
                        ProveedorTile.Enabled = true;
                        ComprobanteTile.Enabled = true;
                        PagosTile.Enabled = true;
                        ConsultaComprobanteTile.Enabled = true;
                        ProductoServicioTile.Enabled = true;
                        SolicitudTile.Enabled = true;
                        PersonalTile.Enabled = true;
                        metroPanel1.Controls.Clear();
                       

                    }
                    if (umanager.Profile(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 2)
                    {
                        SolicitudTile.Enabled = true;
                        PersonalTile.Enabled = true;
                        metroPanel1.Controls.Clear();
                    }
                   
                    if (umanager.Profile(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 4)
                    {
                        ProductoServicioTile.Enabled = true;
                        ProveedorTile.Enabled = true;
                        ComprobanteTile.Enabled = true;
                        SolicitudTile.Enabled = true;
                        PersonalTile.Enabled = true;
                        metroPanel1.Controls.Clear();
                    }
                    metroLabelUsername.Text = metroComboBoxUser.Text;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Refresh();
                }

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }
    } 
}
