﻿using System;
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
    public partial class UCResults : UserControl
    {
        ResultsController controller;
        public UCResults()
        {
            InitializeComponent();
            controller = new ResultsController(this);
            controller.Init();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            controller.DeleteGame();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            controller.GameDetails();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            controller.Search();
        }
    }
}