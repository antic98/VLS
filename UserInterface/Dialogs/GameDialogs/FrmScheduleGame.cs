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

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmScheduleGame : Form
    {
        NewGameController controller;
        public FrmScheduleGame()
        {
            InitializeComponent();
            controller = new NewGameController(this);
            controller.Init();
        }
        
        private void btnScheduleGame_Click(object sender, EventArgs e)
        {
            controller.ScheduleGame();
        }        
    }
}
