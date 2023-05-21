using Domain;
using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmInsertGameResult : Form
    {
        InsertGameResultController controller;

        public FrmInsertGameResult(Game game)
        {
            InitializeComponent();
            controller = new InsertGameResultController(this, game);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            controller.Result();
        }

        private void btnSaveHostStriker_Click(object sender, EventArgs e)
        {
            controller.SaveHostStriker();
        }

        private void btnSaveGuestStriker_Click(object sender, EventArgs e)
        {
            controller.SaveGuestStriker();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            controller.SaveResult();
        }

        private void FrmInsertGameResult_Load(object sender, EventArgs e)
        {
            controller.Init();
        }
    }
}
