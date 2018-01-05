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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        public UserManager umanager = new UserManager();
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

                    
                    //MessageBox.Show("Usuario y Contraseña correcta", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
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
                        //MessageBox.Show("Usuario y Contraseña correcta", "Sistema de Gestion Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (umanager.AuthorizationPRofile(metroComboBoxUser.Text, metroTextBoxContraseña.Text)==1)
                        {
                            
                        }

                        

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

        private void LoginControl_Load(object sender, EventArgs e)
        {
            UserManager u = new UserManager();
            metroComboBoxUser.DataSource = u.ListarUsername();
            metroComboBoxUser.DisplayMember = "name";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxContraseña_Click(object sender, EventArgs e)
        {
            metroTextBoxContraseña.Text = "";
            metroTextBoxContraseña.UseSystemPasswordChar = true;
        }
    }
}
