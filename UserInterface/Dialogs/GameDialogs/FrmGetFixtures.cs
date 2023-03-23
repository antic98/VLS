using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;

namespace UserInterface.Dialogs.GameDialogs
{
    public partial class FrmGetFixtures : Form
    {
        BindingList<Team> teamsGroupA = new BindingList<Team>();
        BindingList<Team> teamsGroupB = new BindingList<Team>();
        BindingList<Team> teams;

        public FrmGetFixtures()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            GetTeams();
            dgvTeamsGroupA.DataSource = teamsGroupA;
            dgvTeamsGroupB.DataSource = teamsGroupB;
        }

        private void GetTeams()
        {
            try
            {
                teams = new BindingList<Team>();

                List<Team> tms = Communication.Instance.GetList(Operation.GetTeams) as List<Team>;

                foreach (Team t in tms)
                {
                    teams.Add(t);
                }

                dgvTeams.DataSource = teams;
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

        private void btnGroupA_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any team.");
            }
            else
            {
                Team t = (Team)dgvTeams.SelectedRows[0].DataBoundItem;

                teams.Remove(t);
                teamsGroupA.Add(t);
            }
        }

        private void btnGroupB_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("You didn't select any team.");
            }
            else
            {
                Team t = (Team)dgvTeams.SelectedRows[0].DataBoundItem;

                teams.Remove(t);
                teamsGroupB.Add(t);
            }
        }

        private void btnGetFixtures_Click(object sender, EventArgs e)
        {
            foreach(Team t in teamsGroupA)
            {
                t.Group = "A";
                Communication.Instance.SaveDeleteUpdate(Operation.UpdateTeam, t);
            }
            foreach (Team t in teamsGroupB)
            {
                t.Group = "B";
                Communication.Instance.SaveDeleteUpdate(Operation.UpdateTeam, t);
            }

            Communication.Instance.SaveDeleteUpdate(Operation.SaveFixtures, teamsGroupA.ToList());
            Communication.Instance.SaveDeleteUpdate(Operation.SaveFixtures, teamsGroupB.ToList());


        }
    }
}
