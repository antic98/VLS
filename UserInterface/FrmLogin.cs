using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface
{
    public partial class FrmLogin : Form
    {
        LoginController controller;
        public FrmLogin()
        {
            InitializeComponent();
            controller = new LoginController(this);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            controller.Login();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Communication.Instance.Close();
        }
    }
}
