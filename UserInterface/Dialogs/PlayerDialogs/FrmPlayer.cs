using Domain;
using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface
{
    public partial class FrmPlayer : Form
    {
        private readonly ChangePlayerController controller;
        
        public FrmPlayer(Player p)
        {
            InitializeComponent();
            controller = new ChangePlayerController(this, p);
            controller.Init();            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            controller.Update();            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }
    }
}
