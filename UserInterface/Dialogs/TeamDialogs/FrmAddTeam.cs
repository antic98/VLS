using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.TeamDialogs
{
    public partial class FrmAddTeam : Form
    {
        private readonly AddTeamController controller;
        public FrmAddTeam()
        {
            InitializeComponent();
            controller = new AddTeamController(this);            
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            controller.AddTeam();
        }
    }
}
