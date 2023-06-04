using Common;
using Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using UserInterface.Dialogs.GameDialogs;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;
using System.Linq;

namespace UserInterface.GUIController
{
    public class AddGamesController
    {
        private readonly FrmAddGames frmAddGames;
        private BindingList<Team> allTeams;
        private BindingList<Team> selectedTeams;

        public AddGamesController(FrmAddGames frmAddGames)
        {
            this.frmAddGames = frmAddGames;
        }

        internal void Init()
        {
            GetTeams();
            selectedTeams = new BindingList<Team>();
            frmAddGames.DgvSelectedTeams.DataSource = selectedTeams;

            frmAddGames.DgvSelectedTeams.Columns[0].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[1].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[4].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[5].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[6].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[7].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[8].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[9].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[10].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[11].Visible = false;
            frmAddGames.DgvSelectedTeams.Columns[12].Visible = false;

            frmAddGames.DgvAllTeams.Columns[0].Visible = false;
            frmAddGames.DgvAllTeams.Columns[1].Visible = false;
            frmAddGames.DgvAllTeams.Columns[4].Visible = false;
            frmAddGames.DgvAllTeams.Columns[5].Visible = false;
            frmAddGames.DgvAllTeams.Columns[6].Visible = false;
            frmAddGames.DgvAllTeams.Columns[7].Visible = false;
            frmAddGames.DgvAllTeams.Columns[8].Visible = false;
            frmAddGames.DgvAllTeams.Columns[9].Visible = false;
            frmAddGames.DgvAllTeams.Columns[10].Visible = false;
            frmAddGames.DgvAllTeams.Columns[11].Visible = false;
            frmAddGames.DgvAllTeams.Columns[12].Visible = false;
        }

        internal void AddGamesSingle()
        {
            if (selectedTeams.Count % 2 == 1)
            {
                MessageBox.Show("You have to select even number of teams.");
                return;
            }

            if (Communication.Instance.SaveDeleteUpdate(Operation.AddGamesSingle, selectedTeams.ToList()))
            {
                MessageBox.Show("Games for this season are added.");
                Dispose();
            }
            else
                MessageBox.Show("Games for this season are not added.");
        }

        internal void AddGamesDouble()
        {
            if(selectedTeams.Count % 2 == 1)
            {
                MessageBox.Show("You have to select even number of teams.");
                return;  
            }

            if (Communication.Instance.SaveDeleteUpdate(Operation.AddGamesDouble, selectedTeams.ToList()))
            {
                MessageBox.Show("Games for this season are added.");
                Dispose();
            }
            else
                MessageBox.Show("Games for this season are not added.");
        }

        internal void AddTeam()
        {
            if (frmAddGames.DgvAllTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any team.");
            }
            else
            {
                var t = (Team)frmAddGames.DgvAllTeams.SelectedRows[0].DataBoundItem;

                allTeams.Remove(t);
                selectedTeams.Add(t);
            }
        }

        internal void RemoveTeam()
        {
            if (frmAddGames.DgvSelectedTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any team.");
            }
            else
            {
                var t = (Team)frmAddGames.DgvSelectedTeams.SelectedRows[0].DataBoundItem;

                selectedTeams.Remove(t);
                allTeams.Add(t);
            }
        }

        private void Dispose()
        {
            frmAddGames.Dispose();
        }

        private void GetTeams()
        {
            try
            {
                allTeams = new BindingList<Team>();

                if (Communication.Instance.GetList(Operation.GetTeams) is List<Team> teams)
                    foreach (var t in teams)
                        allTeams.Add(t);

                frmAddGames.DgvAllTeams.DataSource = allTeams;
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
