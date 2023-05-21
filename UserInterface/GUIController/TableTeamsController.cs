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
        private UCTableTeams uCTableTeams;
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

                object lista = Communication.Instance.GetList(Operation.GetTeams);

                foreach (Team obj in lista as List<Team>) teams.Add(obj as Team);
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

    }
}
