using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCTablePlayers : UserControl
    {
        TablePlayersController controller;

        public UCTablePlayers()
        {
            InitializeComponent();
            controller = new TablePlayersController(this);
            controller.Init();
        }

       
    }
}
