using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
