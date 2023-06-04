using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCAllTeams : UserControl
    {
        private readonly AllTeamsController controller;
        public UCAllTeams()
        {
            InitializeComponent();
            controller = new AllTeamsController(this);

            controller.Init();
        } 

        private void btnShowTeam_Click(object sender, EventArgs e)
        {
            controller.ShowTeam();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            controller.AddTeam();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            controller.Search();
        }
    }
}
