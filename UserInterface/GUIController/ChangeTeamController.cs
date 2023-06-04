﻿using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class ChangeTeamController
    {
        private readonly FrmTeam frmTeam;
        private readonly Team team;
        private BindingList<Player> players;
        public ChangeTeamController(FrmTeam frmTeam, Team team)
        {
            this.frmTeam = frmTeam;
            this.team = team;
        }

        private bool Validation()
        {
            bool succ = true;

            frmTeam.TxtName.BackColor = Color.FromArgb(45, 66, 91);
            frmTeam.TxtCity.BackColor = Color.FromArgb(45, 66, 91);
            frmTeam.TxtColor.BackColor = Color.FromArgb(45, 66, 91);

            if (frmTeam.TxtName.Text == "")
            {
                frmTeam.TxtName.BackColor = Color.YellowGreen;
                succ = false;
            }
            if (frmTeam.TxtCity.Text == "")
            {
                frmTeam.TxtCity.BackColor = Color.YellowGreen;
                succ = false;
            }
            if (frmTeam.TxtColor.Text == "")
            {
                frmTeam.TxtColor.BackColor = Color.YellowGreen;
                succ = false;
            }

            bool pom = true;

            if (frmTeam.TxtName.Text.Length < 3)
            {
                frmTeam.TxtName.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }

            foreach (Char c in frmTeam.TxtCity.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmTeam.TxtCity.BackColor = Color.YellowGreen;
                    succ = false;
                    pom = false;
                    break;
                }
            }

            foreach (Char c in frmTeam.TxtColor.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmTeam.TxtColor.BackColor = Color.YellowGreen;
                    succ = false;
                    pom = false;
                    break;
                }
            }

            if (!pom)
            {
                MessageBox.Show("Name need to have at least 3 characters, city and color can't contain numeric values.");
            }

            return succ;
        }

        internal void Init()
        {
            frmTeam.Text = team.Name;
            frmTeam.Text = team.Name;
            frmTeam.TxtID.Text = team.ID.ToString();
            frmTeam.TxtName.Text = team.Name;
            frmTeam.TxtCity.Text = team.City;
            frmTeam.TxtColor.Text = team.Color;

            frmTeam.LblPlayed.Text = (team.Wins + team.Draws + team.Loses).ToString() + " games (" + team.Wins + "W, " + team.Draws + "D, " + team.Loses + "L)";

            players = new BindingList<Player>(team.Players);
            frmTeam.DgvPlayers.DataSource = players;
            frmTeam.DgvPlayers.Columns["Team"].Visible = false;

            frmTeam.TxtID.Enabled = false;
        }

        internal void Update()
        {
            if (!Validation()) return;

            Team updatedTeam = new Team(frmTeam.TxtName.Text, frmTeam.TxtCity.Text, frmTeam.TxtColor.Text);
            updatedTeam.ID = int.Parse(frmTeam.TxtID.Text);

            if(Communication.Instance.SaveDeleteUpdate(Operation.UpdateTeam, updatedTeam))
            {
                MessageBox.Show($"Team {updatedTeam.Name} is updated.");
                Dispose();
            }
            else
                MessageBox.Show($"Team {updatedTeam.Name} is not updated.");
        }

        internal void Dispose()
        {
            frmTeam.Dispose();
        }

        internal void Delete()
        {
            if (!Validation()) return;

            var result = MessageBox.Show("Are you sure you want to delete this team? If you delete this team, every player and game connected to this team will be deleted.", "Deleting "+ frmTeam.TxtName.Text, System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            Team deleteTeam = new Team();
            deleteTeam.ID = int.Parse(frmTeam.TxtID.Text);

            if (Communication.Instance.SaveDeleteUpdate(Operation.DeleteTeam, deleteTeam))
                MessageBox.Show($"Team {frmTeam.TxtName.Text} is deleted succesfully.");
            else
            {
                MessageBox.Show($"Team {frmTeam.TxtName.Text} is not deleted.");
            }

            Dispose();
        }
    }
}
