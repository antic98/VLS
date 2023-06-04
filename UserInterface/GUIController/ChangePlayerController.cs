using ApplicationLogic;
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
        private readonly FrmPlayer frmPlayer;
        private readonly Player player;

        public ChangePlayerController(FrmPlayer frmPlayer, Player player)
        {
            this.frmPlayer = frmPlayer;
            this.player = player;
        }

        private bool Validation()
        {
            var succ = true;

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

            var pom = true;

            if (frmPlayer.TxtName.Text.Any(char.IsDigit))
            {
                frmPlayer.TxtName.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }
            if (frmPlayer.TxtSurname.Text.Any(char.IsDigit))
            {
                frmPlayer.TxtSurname.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
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
                var countries = Communication.Instance.GetList(Operation.GetCountries) as List<Country>;

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

        private void GetPositions()
        {
            try
            {
                var positions = Communication.Instance.GetList(Operation.GetPositions) as List<Position>;

                frmPlayer.CbPosition.DataSource = positions;
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
                var teams = Communication.Instance.GetList(Operation.GetTeams) as List<Team>;

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
            GetCountries();
            GetPositions();
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

            var updatedPlayer = new Player(int.Parse(frmPlayer.TxtID.Text),
                frmPlayer.TxtName.Text,
                frmPlayer.TxtSurname.Text,
                (Position)frmPlayer.CbPosition.SelectedItem,
                (Country)frmPlayer.CbCountry.SelectedItem,
                (Team)frmPlayer.CbTeam.SelectedItem);
            
            if(updatedPlayer.Team.ID != player.Team.ID)
            {
                var result = MessageBox.Show("Are you sure you want to change this player's club? If you change it, all stats made by this player will be deleted.", "Update " + updatedPlayer.Name + " " + updatedPlayer.Surname, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
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

            var result = MessageBox.Show("Are you sure you want to delete this player? If you delete this player, all stats made by this player will be deleted.", "Deleting " + frmPlayer.TxtName.Text + " " + frmPlayer.TxtSurname.Text, System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            var deletePlayer = new Player
            {
                ID = int.Parse(frmPlayer.TxtID.Text)
            };

            if (Communication.Instance.SaveDeleteUpdate(Operation.DeletePlayer, deletePlayer))
            {
                MessageBox.Show($"Player {frmPlayer.TxtName.Text} {frmPlayer.TxtSurname.Text} is deleted.");
                Dispose();
            }
            else
                MessageBox.Show($"Player {frmPlayer.TxtName.Text} {frmPlayer.TxtSurname.Text} is not deleted.");
        }
    }
}
