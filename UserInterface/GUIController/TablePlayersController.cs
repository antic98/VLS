using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface.GUIController
{
    public class TablePlayersController
    {
        private UCTablePlayers uCTablePlayers;
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

                object lista = Communication.Instance.GetList(Operation.GetPlayers);

                foreach (Player obj in lista as List<Player>) players.Add(obj as Player);
            }
            catch (ServerCommunicationException) //SVUDA BACAJ OVAJ EX
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
