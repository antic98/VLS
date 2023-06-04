using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmScheduleGame : Form
    {
        private readonly NewGameController controller;
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
