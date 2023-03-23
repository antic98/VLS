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
using UserInterface.Dialogs.PlayerDialogs;
using UserInterface.Exceptions;
using UserInterface.GUIController;
using UserInterface.ServerCommunication;

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
