using System;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.PlayerDialogs
{
    public partial class FrmAddPlayer : Form
    {
        private readonly AddPlayerController controller;
        public FrmAddPlayer()
        {
            InitializeComponent();
            controller = new AddPlayerController(this);
            controller.Init();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            controller.AddPlayer();
        }        
    }
}
