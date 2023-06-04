using System.Windows.Forms;
using UserInterface.GUIController;

namespace UserInterface.UserControls
{
    public partial class UCTableTeams : UserControl
    {
        public UCTableTeams()
        {
            InitializeComponent();
            var controller = new TableTeamsController(this);
            controller.Init();
        }
    }
}
