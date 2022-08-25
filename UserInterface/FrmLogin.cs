using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtUsername.Text = "antic";
            txtPassword.Text = "antic";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username == "antic" && password == "antic")
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("GRESKA!");
            }
        }
    }
}
