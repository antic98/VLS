using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface.GUIController
{
    public class TablePlayersController
    {
        private readonly UCTablePlayers uCTablePlayers;
        private BindingList<Player> players;

        public TablePlayersController(UCTablePlayers uCTablePlayers)
        {
            this.uCTablePlayers = uCTablePlayers;
        }

        private void GetPlayers()
        {
            try
            {
                players = new BindingList<Player>();

                var listPlayers = Communication.Instance.GetList(Operation.GetPlayers);
                var listGames = Communication.Instance.GetList(Operation.GetGames);

                foreach (var player in (List<Player>)listPlayers)
                {
                    if (((List<Game>)listGames).Any(game => game.Host.ID == player.Team.ID || game.Guest.ID == player.Team.ID))
                    {
                        players.Add(player);
                    }
                }
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

        internal void Init()
        {
            GetPlayers();
            uCTablePlayers.DgvPlayers.DataSource = players;
            uCTablePlayers.DgvPlayers.Columns[1].Visible = false;
            uCTablePlayers.DgvPlayers.Columns[0].Width = 50;
            uCTablePlayers.DgvPlayers.Columns[7].Width = 50;
        }
    }
}
