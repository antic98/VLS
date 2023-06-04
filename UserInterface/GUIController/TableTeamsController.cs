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
    public class TableTeamsController
    {
        private readonly UCTableTeams uCTableTeams;
        private BindingList<Team> teams;

        public TableTeamsController(UCTableTeams uCTableTeams)
        {
            this.uCTableTeams = uCTableTeams;
        }

        internal void Init()
        {
            GetTeams();
            uCTableTeams.DgvTable.DataSource = teams;
            uCTableTeams.DgvTable.Columns["ID"].Visible = false;

            uCTableTeams.DgvTable.Columns["Rank"].Width = 30;
            uCTableTeams.DgvTable.Columns["MP"].Width = 30;
            uCTableTeams.DgvTable.Columns["Wins"].Width = 30;
            uCTableTeams.DgvTable.Columns["Draws"].Width = 30;
            uCTableTeams.DgvTable.Columns["Loses"].Width = 30;
            uCTableTeams.DgvTable.Columns["GD"].Width = 30;
            uCTableTeams.DgvTable.Columns["Points"].Width = 35;


            uCTableTeams.DgvTable.Columns["GoalsScored"].Visible = false;
            uCTableTeams.DgvTable.Columns["GoalsConceded"].Visible = false;
        }

        private void GetTeams()
        {
            try
            {
                teams = new BindingList<Team>();

                var listTeams = Communication.Instance.GetList(Operation.GetTeams);
                var listGames = Communication.Instance.GetList(Operation.GetGames);

                foreach (var team in (List<Team>)listTeams)
                {
                    foreach (var game in (List<Game>)listGames)
                    {
                        if (game.Host.ID != team.ID && game.Guest.ID != team.ID) continue;
                        teams.Add(team);
                        break;
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

    }
}
