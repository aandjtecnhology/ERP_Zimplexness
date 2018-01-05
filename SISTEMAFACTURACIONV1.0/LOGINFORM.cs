using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAFACTURACIONV1._0
{
    public partial class LOGINFORM : MetroFramework.Forms.MetroForm
    {
        public Thread NuevoHilo { get; private set; }
        public UserManager umanager = new UserManager();

        public LOGINFORM()
        {
            InitializeComponent();
         
        }
        private void RunPrincipal()
        {
            MainForm frm = new MainForm();
           
            frm.MyUserName = umanager.Devolvernombre(metroComboBoxUser.Text, metroTextBoxContraseña.Text);
            frm.ShowDialog();
        }

        private void LOGINFORM_Load(object sender, EventArgs e)
        {
            UserManager u = new UserManager();
            metroComboBoxUser.DataSource = u.ListarUsername();
            metroComboBoxUser.DisplayMember = "name";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroComboBoxUser.Text) == true || string.IsNullOrEmpty(metroTextBoxContraseña.Text) == true)
            {
                MessageBox.Show("Por Favor Inserte el nombre de Usuario y la Contraseña", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                UserManager umanager = new UserManager();


                if (umanager.ValidateUser(metroComboBoxUser.Text, metroTextBoxContraseña.Text) == 1)
                {
                   // MessageBox.Show("Usuario y Contraseña correcta", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    







                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Refresh();
                }

            }
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
                        // MessageBox.Show("Usuario y Contraseña correcta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                       
                        //this.DialogResult = DialogResult.OK;
                        //MainForm mainform = new MainForm();
                        //mainform.IDProfiles = umanager.AuthorizationPRofile(metroComboBoxUser.Text, metroTextBoxContraseña.Text);

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

        private void metroTextBoxContraseña_Click(object sender, EventArgs e)
        {
            metroTextBoxContraseña.Text = "";
            metroTextBoxContraseña.UseSystemPasswordChar = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
