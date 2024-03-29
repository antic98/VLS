﻿using Common;
using Domain;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserInterface.Dialogs.PlayerDialogs;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class AddPlayerController
    {
        private readonly FrmAddPlayer frmAddPlayer;

        public AddPlayerController(FrmAddPlayer frmAddPlayer)
        {
            this.frmAddPlayer = frmAddPlayer;
        }

        private bool Validation()
        {
            var succ = true;

            frmAddPlayer.TxtName.BackColor = Color.FromArgb(45, 66, 91);
            frmAddPlayer.TxtSurname.BackColor = Color.FromArgb(45, 66, 91);
            frmAddPlayer.CbPosition.BackColor = Color.FromArgb(45, 66, 91);
            frmAddPlayer.CbCountry.BackColor = Color.FromArgb(45, 66, 91);
            frmAddPlayer.CbTeam.BackColor = Color.FromArgb(45, 66, 91);

            if (frmAddPlayer.TxtName.Text == "")
            {
                frmAddPlayer.TxtName.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmAddPlayer.TxtSurname.Text == "")
            {
                frmAddPlayer.TxtSurname.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmAddPlayer.CbPosition.SelectedIndex == -1)
            {
                frmAddPlayer.CbPosition.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmAddPlayer.CbCountry.SelectedIndex == -1)
            {
                frmAddPlayer.CbCountry.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmAddPlayer.CbTeam.SelectedIndex == -1)
            {
                frmAddPlayer.CbTeam.BackColor = Color.YellowGreen;
                succ = false;
            }

            var pom = true;

            if (frmAddPlayer.TxtName.Text.Any(char.IsDigit))
            {
                frmAddPlayer.TxtName.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }
            if (frmAddPlayer.TxtSurname.Text.Any(char.IsDigit))
            {
                frmAddPlayer.TxtSurname.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }

            if (!pom)
            {
                MessageBox.Show("Name and surname can't contain numeric values.");
            }

            return succ;
        }

        internal void Init()
        {
            frmAddPlayer.CbCountry.DataSource = Communication.Instance.GetList(Operation.GetCountries);
            frmAddPlayer.CbPosition.DataSource = Communication.Instance.GetList(Operation.GetPositions);
            frmAddPlayer.CbTeam.DataSource = Communication.Instance.GetList(Operation.GetTeams);
        }

        internal void AddPlayer()
        {
            if (!Validation()) return;

            var newPlayer = new Player(frmAddPlayer.TxtName.Text,
                frmAddPlayer.TxtSurname.Text,
                (Position)frmAddPlayer.CbPosition.SelectedItem,
                (Country)frmAddPlayer.CbCountry.SelectedItem,
                (Team)frmAddPlayer.CbTeam.SelectedItem);

            if(Communication.Instance.SaveDeleteUpdate(Operation.AddPlayer, newPlayer))
            {
                MessageBox.Show($"Player {newPlayer.Name} {newPlayer.Surname} is added.");
                Dispose();
            }
            else
                MessageBox.Show("Player is not added.");
        }

        private void Dispose()
        {
            frmAddPlayer.Dispose();
        }
    }
}
