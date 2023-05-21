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
        private UCAllPlayers uCAllPlayers;
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

                object lista = Communication.Instance.GetList(Operation.GetPlayers);

                foreach (Player obj in lista as List<Player>) players.Add(obj as Player);
                                
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

                Player player = new Player();
                player.Name = uCAllPlayers.TxtSearch.Text.ToLower();

                object lista = Communication.Instance.Search(Operation.SearchPlayers, player);

                foreach (Player obj in lista as List<Player>) players.Add(obj as Player);

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
            List<Team> tt = Communication.Instance.GetList(Operation.GetTeams) as List<Team>;
            if(tt.Count == 0)
            {
                MessageBox.Show("There are no teams. You have to add team first.");
                return;
            }

            FrmAddPlayer frmAddPlayer = new FrmAddPlayer();
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
                Player p = (Player)uCAllPlayers.DgvPlayers.SelectedRows[0].DataBoundItem;

                FrmPlayer frmPlayer = new FrmPlayer(p);
                frmPlayer.ShowDialog();

                GetPlayers();
                uCAllPlayers.DgvPlayers.DataSource = players;
            }
        }
    }
}
