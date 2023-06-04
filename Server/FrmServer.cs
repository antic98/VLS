using System;
using System.Windows.Forms;
using Server.SController;

namespace Server
{
    public partial class FrmServer : Form
    {
        private readonly ServerController controller;
        public FrmServer()
        {
            InitializeComponent();
            controller = new ServerController(this);
            controller.Init();            
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.Close(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            controller.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            controller.Stop();            
        }
    }
}
