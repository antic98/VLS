using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Dialogs.PlayerDialogs;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface.GUIController
{
    public class AllPlayersController
    {
        private readonly UCAllPlayers uCAllPlayers;
        private BindingList<Player> players;

        public AllPlayersController(UCAllPlayers uCAllPlayers)
        {
            this.uCAllPlayers = uCAllPlayers;
        }

        internal void InitData()
        {
            GetPlayers();
            uCAllPlayers.DgvPlayers.DataSource = players;

            uCAllPlayers.DgvPlayers.Columns[0].Visible = false;
            uCAllPlayers.DgvPlayers.Columns[1].Visible = false;
            uCAllPlayers.DgvPlayers.Columns[7].Visible = false;
        }

        private void GetPlayers()
        {
            try
            {
                players = new BindingList<Player>();

                var listPlayers = Communication.Instance.GetList(Operation.GetPlayers);

                foreach (var obj in (List<Player>)listPlayers) players.Add(obj);
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void Search()
        {            
            try
            {
                players = new BindingList<Player>();

                var player = new Player
                {
                    Search = uCAllPlayers.TxtSearch.Text.ToLower()
                };

                var listPlayers = Communication.Instance.Search(Operation.SearchPlayers, player);

                foreach (var obj in (List<Player>)listPlayers) players.Add(obj);

                if (players.Count == 0) MessageBox.Show("Can't find any players with that value.");

                uCAllPlayers.DgvPlayers.DataSource = players;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void AddPlayer()
        {
            var tt = Communication.Instance.GetList(Operation.GetTeams) as List<Team>;
            if(tt != null && tt.Count == 0)
            {
                MessageBox.Show("There are no teams. You have to add team first.");
                return;
            }

            var frmAddPlayer = new FrmAddPlayer();
            frmAddPlayer.ShowDialog();

            GetPlayers();
            uCAllPlayers.DgvPlayers.DataSource = players;
        }

        internal void ShowPlayer()
        {
            if (uCAllPlayers.DgvPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any player.");
            }
            else
            {
                var p = (Player)uCAllPlayers.DgvPlayers.SelectedRows[0].DataBoundItem;

                var frmPlayer = new FrmPlayer(p);
                frmPlayer.ShowDialog();

                GetPlayers();
                uCAllPlayers.DgvPlayers.DataSource = players;
            }
        }
    }
}
