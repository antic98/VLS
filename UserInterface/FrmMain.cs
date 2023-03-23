using ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.GUIController;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface
{
    public partial class FrmMain : Form
    {
        MainController controller;
        public FrmMain()
        {
            InitializeComponent();
            controller = new MainController(this);
            controller.Init();            
        }       
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.FormClosed();
        }

        private void playerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            controller.OpenUCAllPlayers();
        }

        private void teamToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            controller.OpenUCAllTeams();
        }

        private void fixturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.OpenUCScheduleGame();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.OpenUCResults();
        }

        private void topScorersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            controller.OpenUCTablePlayers();
        }

        private void standingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            controller.OpenUCTableTeams();
        }
    }
}
