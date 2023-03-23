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
using UserInterface.GUIController;

namespace UserInterface.Dialogs.TeamDialogs
{
    public partial class FrmAddTeam : Form
    {
        AddTeamController controller;
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
