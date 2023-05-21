﻿using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Dialogs.GameDialogs;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class GameDetailsController
    {
        private FrmGameDetails frmGameDetails;
        private Game game;

        public GameDetailsController(FrmGameDetails frmGameDetails, Domain.Game game)
        {
            this.frmGameDetails = frmGameDetails;
            this.game = game;
        }

        internal void Init()
        {
            frmGameDetails.Text = game.Host.Name + " vs " + game.Guest.Name;
            frmGameDetails.LblDate.Text = game.Date.ToString("dd.MM.yyyy. HH:mm");
            frmGameDetails.LblHost.Text = game.Host.Name;
            frmGameDetails.LblGuest.Text = game.Guest.Name;
            frmGameDetails.LblHostGoals.Text = game.GoalsHost.ToString();
            frmGameDetails.LblGuestGoals.Text = game.GoalsGuest.ToString();

            List<Stats> stats = Communication.Instance.GetList(Operation.GetStats) as List<Stats>;

            foreach(Stats st in stats)
            {
                if(st.Player.Team.ID == game.Host.ID && st.Game.ID == game.ID)
                {
                    frmGameDetails.LblHostStrikers.Text += st + Environment.NewLine;
                }
                if(st.Player.Team.ID == game.Guest.ID && st.Game.ID == game.ID)
                {
                    frmGameDetails.LblGuestStrikers.Text += st + Environment.NewLine;
                }
            }

        }
    }
}