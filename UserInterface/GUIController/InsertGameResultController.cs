using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Dialogs.GameDialogs;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class InsertGameResultController
    {
        private readonly FrmInsertGameResult frmInsertGameResult;
        private readonly Game game;
        private readonly List<Stats> stats = new List<Stats>();
        private BindingList<Player> hostPlayers = new BindingList<Player>();
        private BindingList<Player> guestPlayers = new BindingList<Player>();
        private List<Player> players;
        int hostBrojac, guestBrojac;

        public InsertGameResultController(FrmInsertGameResult frmInsertGameResult, Domain.Game game)
        {
            this.game = game;
            this.frmInsertGameResult = frmInsertGameResult;
        }
        
        private void GetPlayers()
        {
            try
            {
                players = Communication.Instance.GetList(Operation.GetPlayers) as List<Player>;

                foreach(Player p in players)
                {
                    if (p.Team.ID == game.Host.ID)
                        hostPlayers.Add(p);
                    if (p.Team.ID == game.Guest.ID)
                        guestPlayers.Add(p);
                }

                frmInsertGameResult.DgvHostPlayers.DataSource = hostPlayers;
                frmInsertGameResult.DgvGuestPlayers.DataSource = guestPlayers;
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
            frmInsertGameResult.Text = game.Host.Name + " vs " + game.Guest.Name;
            frmInsertGameResult.LblHost.Text = game.Host.Name;
            frmInsertGameResult.LblGuest.Text = game.Guest.Name;
            frmInsertGameResult.LblDate.Text = game.Date.ToString("dd.MM.yyyy. HH:mm");
            GetPlayers();
                                    
            frmInsertGameResult.DgvHostPlayers.Columns[0].Visible = false;
            frmInsertGameResult.DgvHostPlayers.Columns[1].Visible = false;
            frmInsertGameResult.DgvHostPlayers.Columns[4].Visible = false;
            frmInsertGameResult.DgvHostPlayers.Columns[5].Visible = false;
            frmInsertGameResult.DgvHostPlayers.Columns[6].Visible = false;
            frmInsertGameResult.DgvHostPlayers.Columns[7].Visible = false;

            frmInsertGameResult.DgvGuestPlayers.Columns[0].Visible = false;
            frmInsertGameResult.DgvGuestPlayers.Columns[1].Visible = false;
            frmInsertGameResult.DgvGuestPlayers.Columns[4].Visible = false;
            frmInsertGameResult.DgvGuestPlayers.Columns[5].Visible = false;
            frmInsertGameResult.DgvGuestPlayers.Columns[6].Visible = false;
            frmInsertGameResult.DgvGuestPlayers.Columns[7].Visible = false;

            bool succ1 = true;
            bool succ2 = true;

            if (hostPlayers.Count == 0)
            {
                frmInsertGameResult.BtnResult.Enabled = false;
                succ1 = false;
            }
            if (guestPlayers.Count == 0)
            {
                frmInsertGameResult.BtnResult.Enabled = false;
                succ2 = false;
            }

            if (!succ1 && !succ2)
            {
                MessageBox.Show("Both teams need to have players to insert result. Please add players first for " + game.Host.Name + " and " + game.Guest.Name + ".");
            }else if(!succ1)
            {
                MessageBox.Show("Both teams need to have players to insert result. Please add players first for " + game.Host.Name + ".");
            }else if(!succ2)
            {
                MessageBox.Show("Both teams need to have players to insert result. Please add players first for " + game.Guest.Name + ".");
            }           

            if(!succ1 || !succ2)
            {
                frmInsertGameResult.Dispose();
            }
        }        

        internal void Result()
        {
            game.GoalsHost = (int)frmInsertGameResult.NumericHost.Value;
            game.GoalsGuest = (int)frmInsertGameResult.NumericGuest.Value;

            frmInsertGameResult.BtnResult.Enabled = false;

            if(game.GoalsHost > 0)
            {
                frmInsertGameResult.BtnSaveHostStriker.Enabled = true;
                frmInsertGameResult.LblHostStrikers.Visible = true;
            }

            if (game.GoalsGuest > 0)
            {
                frmInsertGameResult.BtnSaveGuestStriker.Enabled = true;
                frmInsertGameResult.LblGuestStrikers.Visible = true;
            }

            if(game.GoalsHost == 0 && game.GoalsGuest == 0)
            {
                frmInsertGameResult.BtnSaveResult.Enabled = true;
            }
        }

        internal void SaveHostStriker()
        {
            if (frmInsertGameResult.DgvHostPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't choose player.");                
            }
            else
            {
                ++hostBrojac;
                Stats stat = new Stats(game,
                    frmInsertGameResult.DgvHostPlayers.SelectedRows[0].DataBoundItem as Player,
                    1);

                foreach(Stats st in stats)
                {
                    if(stat.Player.ID == st.Player.ID)
                    {
                        st.Goals++;
                        frmInsertGameResult.LblHostStrikers.Text += Environment.NewLine + hostBrojac + ". " + stat.Player.Name + " " + stat.Player.Surname;
                        if (hostBrojac == game.GoalsHost)
                        {
                            frmInsertGameResult.BtnSaveHostStriker.Enabled = false;
                            if (guestBrojac == game.GoalsGuest)
                                frmInsertGameResult.BtnSaveResult.Enabled = true;
                        }                            
                        return;
                    }
                }
                stats.Add(stat);
                frmInsertGameResult.LblHostStrikers.Text += Environment.NewLine + hostBrojac + ". " + stat.Player.Name + " " + stat.Player.Surname;

                if (hostBrojac == game.GoalsHost)
                {
                    frmInsertGameResult.BtnSaveHostStriker.Enabled = false;
                    if (guestBrojac == game.GoalsGuest)
                        frmInsertGameResult.BtnSaveResult.Enabled = true;
                }
            }
        }


        internal void SaveGuestStriker()
        {
            if (frmInsertGameResult.DgvGuestPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't choose player.");
            }
            else
            {
                ++guestBrojac;
                Stats stat = new Stats(game,
                    frmInsertGameResult.DgvGuestPlayers.SelectedRows[0].DataBoundItem as Player,
                    1);

                foreach (Stats st in stats)
                {
                    if (stat.Player.ID == st.Player.ID)
                    {
                        st.Goals++;
                        frmInsertGameResult.LblGuestStrikers.Text += Environment.NewLine + guestBrojac + ". " + stat.Player.Name + " " + stat.Player.Surname;
                        if (guestBrojac == game.GoalsGuest)
                        {
                            frmInsertGameResult.BtnSaveGuestStriker.Enabled = false;
                            if (hostBrojac == game.GoalsHost)
                                frmInsertGameResult.BtnSaveResult.Enabled = true;
                        }
                        return;
                    }
                }
                stats.Add(stat);
                frmInsertGameResult.LblGuestStrikers.Text += Environment.NewLine + guestBrojac + ". " + stat.Player.Name + " " + stat.Player.Surname;

                if (guestBrojac == game.GoalsGuest)
                {
                    frmInsertGameResult.BtnSaveGuestStriker.Enabled = false;
                    if (hostBrojac == game.GoalsHost)
                        frmInsertGameResult.BtnSaveResult.Enabled = true;
                }
            }
        }

        internal void SaveResult()
        {
            game.Stats = stats;

            if (Communication.Instance.SaveDeleteUpdate(Operation.UpdateGame, game))
            {
                MessageBox.Show("Game and stats are saved.");
                frmInsertGameResult.Dispose();
            }
            else
                MessageBox.Show("Game and stats are not saved.");
        }
    }
}
