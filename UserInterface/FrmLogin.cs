using ApplicationLogic;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Exceptions;
using UserInterface.GUIController;
using UserInterface.ServerCommunication;

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
