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
