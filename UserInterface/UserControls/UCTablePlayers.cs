using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCTablePlayers : UserControl
    {
        public UCTablePlayers()
        {
            InitializeComponent();
            var controller = new TablePlayersController(this);
            controller.Init();
        }

       
    }
}
