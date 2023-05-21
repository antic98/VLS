using Common;
using Domain;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserInterface.Dialogs.PlayerDialogs;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class AddPlayerController
    {
        private FrmAddPlayer frmAddPlayer;

        public AddPlayerController(FrmAddPlayer frmAddPlayer)
        {
            this.frmAddPlayer = frmAddPlayer;
        }

        private bool Validation()
        {
            bool succ = true;

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

            bool pom = true;

            foreach (Char c in frmAddPlayer.TxtName.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmAddPlayer.TxtName.BackColor = Color.YellowGreen;
                    succ = false;
                    pom = false;
                }
            }
            foreach (Char c in frmAddPlayer.TxtSurname.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmAddPlayer.TxtSurname.BackColor = Color.YellowGreen;
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

        internal void Init()
        {
            frmAddPlayer.CbCountry.DataSource = Communication.Instance.GetList(Operation.GetCountries);
            frmAddPlayer.CbPosition.DataSource = Communication.Instance.GetList(Operation.GetPositions);
            frmAddPlayer.CbTeam.DataSource = Communication.Instance.GetList(Operation.GetTeams);
        }

        internal void AddPlayer()
        {
            if (!Validation()) return;

            Player newPlayer = new Player();

            newPlayer.Name = frmAddPlayer.TxtName.Text;
            newPlayer.Surname = frmAddPlayer.TxtSurname.Text;
            newPlayer.Position = (Position)frmAddPlayer.CbPosition.SelectedItem;
            newPlayer.Team = (Team)frmAddPlayer.CbTeam.SelectedItem;
            newPlayer.Country = (Country)frmAddPlayer.CbCountry.SelectedItem;

            if(Communication.Instance.SaveDeleteUpdate(Operation.SavePlayer, newPlayer))
            {
                MessageBox.Show($"Player {newPlayer.Name} {newPlayer.Surname} is added.");
                Dispose();
            }
            else
                MessageBox.Show("Player is not added.");
        }

        internal void Dispose()
        {
            frmAddPlayer.Dispose();
        }
    }
}
