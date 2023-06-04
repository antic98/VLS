using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UserInterface.Dialogs.GameDialogs;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface.GUIController
{
    public class ResultsController
    {
        private readonly UCResults uCResults;
        private BindingList<Game> games;

        public ResultsController(UCResults uCResults)
        {
            this.uCResults = uCResults;
        }

        internal void Init()
        {
            GetGames();
            uCResults.DgvGames.DataSource = games;

            uCResults.DgvGames.Columns[0].Visible = false;
            uCResults.DgvGames.Columns["GoalsHost"].HeaderText = "Goals";
            uCResults.DgvGames.Columns["GoalsGuest"].HeaderText = "Goals";
            uCResults.DgvGames.Columns[6].Width = 60;
        }

        internal void DeleteGame()
        {
            if (uCResults.DgvGames.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any game.");
            }
            else
            {
                var deleteGame = (Game)uCResults.DgvGames.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show("Are you sure you want to delete this result? If you delete this result, all stats about scorers will be deleted.", "Deleting " + deleteGame.Host.Name + " vs " + deleteGame.Guest.Name, System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                MessageBox.Show(Communication.Instance.SaveDeleteUpdate(Operation.DeleteGame, deleteGame)
                    ? "The game is deleted."
                    : "The game is not deleted.");
            }

            GetGames();
            uCResults.DgvGames.DataSource = games;
        }

        internal void Search()
        {
            try
            {
                games = new BindingList<Game>();

                var game = new Game
                {
                    Search = uCResults.TxtSearch.Text.ToLower()
                };

                var listGames = Communication.Instance.Search(Operation.SearchGames, game);

                foreach (var obj in ((List<Game>)listGames).Where(obj => obj.GoalsHost > -1 && obj.GoalsGuest > -1))
                {
                    games.Add(obj);
                }

                if (games.Count == 0) MessageBox.Show("Can't find any games with that value.");

                uCResults.DgvGames.DataSource = games;
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

        internal void GameDetails()
        {
            if (uCResults.DgvGames.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any game.");
            }
            else
            {
                var game = (Game)uCResults.DgvGames.SelectedRows[0].DataBoundItem;

                var frmGameDetails = new FrmGameDetails(game);
                frmGameDetails.ShowDialog();
            }
        }

        private void GetGames()
        {
            try
            {
                games = new BindingList<Game>();

                var listGames = Communication.Instance.GetList(Operation.GetGames);

                foreach (var obj in ((List<Game>)listGames).Where(obj => obj.GoalsHost > -1 && obj.GoalsGuest > -1))
                {
                    games.Add(obj);
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

        internal void FilterRounds()
        {
            try
            {
                if (uCResults.NumericRound.Value == 0)
                {
                    GetGames();
                }
                else
                {
                    games = new BindingList<Game>();

                    var listGames = Communication.Instance.GetList(Operation.GetGames);

                    foreach (var obj in ((List<Game>)listGames).Where(obj => obj.GoalsHost > -1 && obj.GoalsGuest > -1 && obj.Round == uCResults.NumericRound.Value))
                    {
                        games.Add(obj);
                    }
                }

                uCResults.DgvGames.DataSource = games;
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
    }
}
