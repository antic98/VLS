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
using UserInterface.ServerCommunication;

namespace UserInterface.Dialogs.PlayerDialogs
{
    public partial class FrmAddPlayer : Form
    {
        AddPlayerController controller;
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
