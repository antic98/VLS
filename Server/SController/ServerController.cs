﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Controller
{
    public class ServerController
    {
        private FrmServer frmServer;
        private Server server;

        public ServerController(FrmServer frmServer)
        {
            this.frmServer = frmServer;
        }

        internal void Init()
        {
            frmServer.BtnStart.Enabled = true;
            frmServer.BtnStop.Enabled = false;

            frmServer.FormClosed += Close;
        }

        internal void Close(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        internal void Start()
        {
            server = new Server();
            if (server.Start())
            {
                frmServer.BtnStart.Enabled = false;
                frmServer.BtnStop.Enabled = true;
                frmServer.TxtStarted.Text = "Server is started";
                Thread nit = new Thread(server.Listen);
                nit.IsBackground = true;
                nit.Start();
            }
            else
            {
                frmServer.TxtStarted.Text = "Server is not started";
            }
        }

        internal void Stop()
        {
            server?.Stop();
            frmServer.BtnStart.Enabled = true;
            frmServer.BtnStop.Enabled = false;
            frmServer.TxtStarted.Text = "Server is stopped";
        }
    }
}