using Domain;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmGameDetails : Form
    {
        GameDetailsController controller;
        public FrmGameDetails(Game game)
        {
            InitializeComponent();
            controller = new GameDetailsController(this, game);
            controller.Init();
        }
    }
}
