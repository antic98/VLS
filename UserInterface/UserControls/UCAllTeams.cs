using ApplicationLogic;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Dialogs.TeamDialogs;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCAllTeams : UserControl
    {
        AllTeamsController controller;
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
