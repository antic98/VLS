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
using UserInterface.Dialogs.GameDialogs;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCScheduleGame : UserControl
    {
        ScheduleGameController controller;
        public UCScheduleGame()
        {
            InitializeComponent();
            controller = new ScheduleGameController(this);
            controller.Init();
        }
        private void btnScheduleGame_Click(object sender, EventArgs e)
        {
            controller.ScheduleNewGame();            
        }
        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            controller.DeleteGame();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void btnInsertResult_Click(object sender, EventArgs e)
        {
            controller.InsertResult();
        }

        private void btnAddFixtures_Click(object sender, EventArgs e)
        {
            controller.AddFixtures();
        }
    }
}
