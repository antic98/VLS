﻿using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class ChangePlayerController
    {
        private FrmPlayer frmPlayer;
        private Player player;

        public ChangePlayerController(FrmPlayer frmPlayer, Player p)
        {
            this.frmPlayer = frmPlayer;
            this.player = p;
        }

        private bool Validation()
        {
            bool succ = true;

            frmPlayer.TxtName.BackColor = Color.FromArgb(45, 66, 91);
            frmPlayer.TxtSurname.BackColor = Color.FromArgb(45, 66, 91);
            frmPlayer.CbPosition.BackColor = Color.FromArgb(45, 66, 91);
            frmPlayer.CbCountry.BackColor = Color.FromArgb(45, 66, 91);
            frmPlayer.CbTeam.BackColor = Color.FromArgb(45, 66, 91);

            if (frmPlayer.TxtName.Text == "")
            {
                frmPlayer.TxtName.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmPlayer.TxtSurname.Text == "")
            {
                frmPlayer.TxtSurname.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmPlayer.CbPosition.SelectedIndex == -1)
            {
                frmPlayer.CbPosition.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmPlayer.CbCountry.SelectedIndex == -1)
            {
                frmPlayer.CbCountry.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmPlayer.CbTeam.SelectedIndex == -1)
            {
                frmPlayer.CbTeam.BackColor = Color.YellowGreen;
                succ = false;
            }

            bool pom = true;

            foreach (Char c in frmPlayer.TxtName.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmPlayer.TxtName.BackColor = Color.YellowGreen;
                    succ = false;
                    pom = false;
                }
            }
            foreach (Char c in frmPlayer.TxtSurname.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmPlayer.TxtSurname.BackColor = Color.YellowGreen;
                    succ = false;
                    pom = false;
                }
            }

            if (!pom)
            {
                MessageBox.Show("Name and surname can't contain numeric values.");
            }

            return succ;
        }

        private void GetCountries()
        {
            try
            {
                List<Country> countries = Communication.Instance.GetList(Operation.GetCountries) as List<Country>;

                frmPlayer.CbCountry.DataSource = countries;
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

        private void GetTeams()
        {
            try
            {
                List<Team> teams = Communication.Instance.GetList(Operation.GetTeams) as List<Team>;

                frmPlayer.CbTeam.DataSource = teams;
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
            frmPlayer.CbPosition.DataSource = Enum.GetValues(typeof(Position));
            GetCountries();
            GetTeams();

            frmPlayer.Text = $"{player.Name} {player.Surname}";

            frmPlayer.TxtID.Text = player.ID.ToString();
            frmPlayer.TxtName.Text = player.Name;
            frmPlayer.TxtSurname.Text = player.Surname;
            frmPlayer.CbCountry.Text = player.Country.Name;
            frmPlayer.CbPosition.Text = player.Position.ToString();
            frmPlayer.CbTeam.Text = player.Team.Name;

            frmPlayer.TxtID.Enabled = false;
        }

        internal void Dispose()
        {
            frmPlayer.Dispose();
        }

        internal void Update()
        {
            if (!Validation()) return;

            Player updatedPlayer = new Player();

            updatedPlayer.ID = int.Parse(frmPlayer.TxtID.Text);
            updatedPlayer.Name = frmPlayer.TxtName.Text;
            updatedPlayer.Surname = frmPlayer.TxtSurname.Text;
            updatedPlayer.Position = (Position)frmPlayer.CbPosition.SelectedItem;
            updatedPlayer.Team = (Team)frmPlayer.CbTeam.SelectedItem;
            updatedPlayer.Country = (Country)frmPlayer.CbCountry.SelectedItem;
            updatedPlayer.Stats = Communication.Instance.GetList(Operation.GetStats) as List<Stats>;

            if(updatedPlayer.Team.ID != player.Team.ID)
            {
                var result = System.Windows.Forms.MessageBox.Show("Are you sure you want to change this player's club? If you change it, all stats made by this player will be deleted.", "Update " + frmPlayer.TxtName.Text + " " + frmPlayer.TxtSurname.Text, System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            if (Communication.Instance.SaveDeleteUpdate(Operation.UpdatePlayer, updatedPlayer))
            {
                MessageBox.Show($"Player {updatedPlayer.Name} {updatedPlayer.Surname} is updated.");
                Dispose();
            }
            else
                MessageBox.Show($"Player {updatedPlayer.Name} {updatedPlayer.Surname} is not updated.");
        }

        internal void Delete()
        {
            if (!Validation()) return;

            var result = System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this player? If you delete this player, all stats made by this player will be deleted.", "Deleting " + frmPlayer.TxtName.Text + " " + frmPlayer.TxtSurname.Text, System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            Player deletePlayer = new Player();
            deletePlayer.ID = int.Parse(frmPlayer.TxtID.Text);
            deletePlayer.Name = frmPlayer.TxtName.Text;
            deletePlayer.Surname = frmPlayer.TxtSurname.Text;
            deletePlayer.Stats = Communication.Instance.GetList(Operation.GetStats) as List<Stats>;

            if (Communication.Instance.SaveDeleteUpdate(Operation.DeletePlayer, deletePlayer))
            {
                MessageBox.Show($"Player {deletePlayer.Name} {deletePlayer.Surname} is deleted.");
                Dispose();
            }
            else
                MessageBox.Show($"Player {deletePlayer.Name} {deletePlayer.Surname} is not deleted.");
        }
    }
}