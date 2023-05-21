using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCAllPlayers : UserControl
    {
        AllPlayersController controller;
        public UCAllPlayers()
        {
            InitializeComponent();
            controller = new AllPlayersController(this);            
            controller.InitData();
        }

        private void btnShowPlayer_Click(object sender, EventArgs e)
        {
            controller.ShowPlayer();            
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            controller.AddPlayer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            controller.Search();
        }
    }
}
