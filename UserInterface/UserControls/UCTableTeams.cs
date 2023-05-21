using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCTableTeams : UserControl
    {
        TableTeamsController controller;

        public UCTableTeams()
        {
            InitializeComponent();
            controller = new TableTeamsController(this);
            controller.Init();
        }
    }
}
