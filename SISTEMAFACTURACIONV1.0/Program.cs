using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAFACTURACIONV1._0
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
     

            //LOGINFORM  loginfrm = new LOGINFORM();
            //loginfrm.ShowDialog();




            //if (loginfrm.DialogResult == DialogResult.OK)
            
                
                Application.Run(new MainForm());
               



        }
    }
}
