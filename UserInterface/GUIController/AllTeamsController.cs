using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Dialogs.TeamDialogs;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface.GUIController
{
    public class AllTeamsController
    {
        private UCAllTeams uCAllTeams;
        BindingList<Team> teams;
        public AllTeamsController(UCAllTeams uCAllTeams)
        {
            this.uCAllTeams = uCAllTeams;
        }

        internal void Init()
        {
            GetTeams();
            uCAllTeams.DgvTeams.DataSource = teams;
            uCAllTeams.DgvTeams.Columns[0].Visible = false;
            uCAllTeams.DgvTeams.Columns[1].Visible = false;
            uCAllTeams.DgvTeams.Columns[5].Visible = false;
            uCAllTeams.DgvTeams.Columns[6].Visible = false;
            uCAllTeams.DgvTeams.Columns[7].Visible = false;
            uCAllTeams.DgvTeams.Columns[8].Visible = false;
            uCAllTeams.DgvTeams.Columns[9].Visible = false;
            uCAllTeams.DgvTeams.Columns[10].Visible = false;
            uCAllTeams.DgvTeams.Columns[11].Visible = false;
            uCAllTeams.DgvTeams.Columns[12].Visible = false;
        }

        private void GetTeams()
        {
            try
            {
                teams = new BindingList<Team>();

                object lista = Communication.Instance.GetList(Operation.GetTeams);

                foreach (Team obj in lista as List<Team>) teams.Add(obj as Team);
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
                teams = new BindingList<Team>();

                Team team = new Team();
                team.Name = uCAllTeams.TxtSearch.Text.ToLower();

                object lista = Communication.Instance.Search(Operation.SearchTeams, team);

                foreach (Team obj in lista as List<Team>) teams.Add(obj as Team);

                if (teams.Count == 0) MessageBox.Show("Can't find any teams with that value.");

                uCAllTeams.DgvTeams.DataSource = teams;
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

        internal void ShowTeam()
        {
            if (uCAllTeams.DgvTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any team.");
            }
            else
            {
                Team t = (Team)uCAllTeams.DgvTeams.SelectedRows[0].DataBoundItem;
                t.Players = new List<Player>();
                List<Player> players = Communication.Instance.GetList(Operation.GetPlayers) as List<Player>;

                foreach(Player p in players)
                {
                    if (p.Team.ID == t.ID) t.Players.Add(p);
                }

                FrmTeam frmTeam = new FrmTeam(t);
                frmTeam.ShowDialog();

                GetTeams();
                uCAllTeams.DgvTeams.DataSource = teams;
            }
        }

        internal void AddTeam()
        {
            FrmAddTeam frmAddTeam = new FrmAddTeam();
            frmAddTeam.ShowDialog();
            GetTeams();
            uCAllTeams.DgvTeams.DataSource = teams;
        }
    }
}
