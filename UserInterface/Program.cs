using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Exceptions;

namespace UserInterface
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());


            while (true)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    DialogResult result = frmLogin.ShowDialog();
                    frmLogin.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if(result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch(ServerCommunicationException)
                {
                    MessageBox.Show("Can't connect to server!");
                }

            }
        }
    }
}
