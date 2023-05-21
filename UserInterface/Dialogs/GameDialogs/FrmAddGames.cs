using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmAddGames : Form
    {
        AddGamesController controller;

        public FrmAddGames()
        {
            InitializeComponent();
            controller = new AddGamesController(this);
        }

        private void btnAddTeam_Click_1(object sender, EventArgs e)
        {
            controller.AddTeam();
        }

        private void btnAddGames_Click_1(object sender, EventArgs e)
        {
            controller.AddGamesSingle();
        }

        private void FrmAddGames_Load(object sender, EventArgs e)
        {
            controller.Init();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            controller.RemoveTeam();
        }

        private void btnAddGamesDouble_Click(object sender, EventArgs e)
        {
            controller.AddGamesDouble();
        }
    }
}
