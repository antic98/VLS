using ApplicationLogic;
using Domain;
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
