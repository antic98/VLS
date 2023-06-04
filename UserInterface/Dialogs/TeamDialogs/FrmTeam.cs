using Domain;
using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface
{
    public partial class FrmTeam : Form
    {
        private readonly ChangeTeamController controller;
        public FrmTeam(Team t)
        {
            InitializeComponent();
            controller = new ChangeTeamController(this, t);
            controller.Init();            
        }
        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            controller.Update();           
        }
        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            controller.Delete();            
        }
    }
}
