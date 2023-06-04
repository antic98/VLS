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
    public class ScheduleGameController
    {
        private readonly UCScheduleGame uCScheduleGame;
        private BindingList<Game> games;

        public ScheduleGameController(UCScheduleGame uCScheduleGame)
        {
            this.uCScheduleGame = uCScheduleGame;
        }

        internal void ScheduleNewGame()
        {
            var tt = Communication.Instance.GetList(Operation.GetTeams) as List<Team>;
            if(tt != null && tt.Count < 2)
            {
                MessageBox.Show("There have to be at least 2 teams to schedule a game. You have to add team first.");
                return;
            }

            FrmScheduleGame frmScheduleGame = new FrmScheduleGame();
            frmScheduleGame.ShowDialog();

            GetGames();
            uCScheduleGame.DgvGames.DataSource = games;
        }

        private void GetGames()
        {
            try
            {
                games = new BindingList<Game>();

                var listGames = Communication.Instance.GetList(Operation.GetGames);

                foreach (var obj in ((List<Game>)listGames).Where(obj => obj.GoalsHost == -1 && obj.GoalsGuest == -1))
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

        internal void AddFixtures()
        {
            var frmGetFixtures = new FrmAddGames();
            frmGetFixtures.ShowDialog();
        }

        internal void InsertResult()
        {
            if (uCScheduleGame.DgvGames.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any game.");
            }
            else
            {
                var g = (Game)uCScheduleGame.DgvGames.SelectedRows[0].DataBoundItem;

                var frmInsertGameResult = new FrmInsertGameResult(g);
                frmInsertGameResult.ShowDialog();

                GetGames();
                uCScheduleGame.DgvGames.DataSource = games;
            }
        }

        internal void Search()
        {
            try
            {
                games = new BindingList<Game>();

                var game = new Game();
                game.Search = uCScheduleGame.TxtSearch.Text.ToLower();

                var listGames = Communication.Instance.Search(Operation.SearchGames, game);

                foreach (var obj in ((List<Game>)listGames).Where(obj => obj.GoalsHost == -1 && obj.GoalsGuest == -1))
                {
                    games.Add(obj);
                }

                if (games.Count == 0) MessageBox.Show("Can't find any games with that value.");

                uCScheduleGame.DgvGames.DataSource = games;
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
            GetGames();
            uCScheduleGame.DgvGames.DataSource = games;

            uCScheduleGame.DgvGames.Columns[0].Visible = false;
            uCScheduleGame.DgvGames.Columns[3].Visible = false;
            uCScheduleGame.DgvGames.Columns[4].Visible = false;
            uCScheduleGame.DgvGames.Columns[6].Width = 60;
        }

        internal void DeleteGame()
        {
            if (uCScheduleGame.DgvGames.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any game.");
            }
            else
            {
                var game = (Game)uCScheduleGame.DgvGames.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show("Are you sure you want to delete this fixture?", "Deleting " + game.Host.Name + " vs " + game.Guest.Name, System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                if (Communication.Instance.SaveDeleteUpdate(Operation.DeleteGame, game))
                    MessageBox.Show("The game is deleted.");
                else
                    MessageBox.Show("The game is not deleted.");
            }

            GetGames();
            uCScheduleGame.DgvGames.DataSource = games;
        }

        internal void FilterRounds()
        {
            try
            {
                if (uCScheduleGame.NumericRound.Value == 0)
                {
                    GetGames();
                }
                else
                {
                    games = new BindingList<Game>();

                    var listGames = Communication.Instance.GetList(Operation.GetGames);

                    foreach (var obj in ((List<Game>)listGames).Where(obj => obj.GoalsHost == -1 && obj.GoalsGuest == -1 && obj.Round == uCScheduleGame.NumericRound.Value))
                    {
                        games.Add(obj);
                    }
                }

                uCScheduleGame.DgvGames.DataSource = games;
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
