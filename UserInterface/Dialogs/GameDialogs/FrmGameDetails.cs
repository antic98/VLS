using Domain;
using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmGameDetails : Form
    {
        public FrmGameDetails(Game game)
        {
            InitializeComponent();
            var controller = new GameDetailsController(this, game);
            controller.Init();
        }
    }
}
