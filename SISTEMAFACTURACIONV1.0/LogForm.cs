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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            UserManager u = new UserManager();
            comboBoxUserName.DataSource = u.ListarUsername();
            comboBoxUserName.DisplayMember = "name";
        


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxUserName.Text) == true || string.IsNullOrEmpty(textBoxPassword.Text) == true)
            {
                MessageBox.Show("Por Favor Inserte el nombre de Usuario y la Contraseña", "Sistema de Gestion Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                UserManager umanager = new UserManager();
               

                if (umanager.ValidateUser(comboBoxUserName.Text, textBoxPassword.Text) == 1)
                {
                    MessageBox.Show("Usuario y Contraseña correcta", "Sistema de Gestion Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                  
                    MainForm MainFrm = new MainForm();
                    MainFrm.MyUserName = umanager.Devolvernombre(comboBoxUserName.Text,textBoxPassword.Text);
                    MainFrm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUserName_Click(object sender, EventArgs e)
        {
           

        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";
        }

        private void LogForm_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void LogForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(comboBoxUserName.Text) == true || string.IsNullOrEmpty(textBoxPassword.Text) == true)
                {
                    MessageBox.Show("Por Favor Inserte el nombre de Usuario y la Contraseña","Sistema de Gestion Facturacion", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    UserManager umanager = new UserManager();

                    if (umanager.ValidateUser(comboBoxUserName.Text, textBoxPassword.Text) == 1)
                    {
                        MessageBox.Show("Usuario y Contraseña correcta", "Sistema de Gestion Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm MainFrm = new MainForm();

                        
                        MainFrm.MyUserName = umanager.Devolvernombre(comboBoxUserName.Text, textBoxPassword.Text);
                        MainFrm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                       
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Sistema de Gestion Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
