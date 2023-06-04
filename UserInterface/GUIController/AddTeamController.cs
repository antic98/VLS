using Common;
using Domain;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UserInterface.Dialogs.TeamDialogs;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class AddTeamController
    {
        private readonly FrmAddTeam frmAddTeam;

        public AddTeamController(FrmAddTeam frmAddTeam)
        {
            this.frmAddTeam = frmAddTeam;
        }

        private void Dispose()
        {
            frmAddTeam.Dispose();
        }

        private bool Validation()
        {
            var succ = true;

            frmAddTeam.TxtName.BackColor = Color.FromArgb(45, 66, 91);
            frmAddTeam.TxtCity.BackColor = Color.FromArgb(45, 66, 91);
            frmAddTeam.TxtColor.BackColor = Color.FromArgb(45, 66, 91);

            if (frmAddTeam.TxtName.Text == "")
            {
                frmAddTeam.TxtName.BackColor = Color.YellowGreen;
                succ = false;
            }
            if (frmAddTeam.TxtCity.Text == "")
            {
                frmAddTeam.TxtCity.BackColor = Color.YellowGreen;
                succ = false;
            }
            if (frmAddTeam.TxtColor.Text == "")
            {
                frmAddTeam.TxtColor.BackColor = Color.YellowGreen;
                succ = false;
            }

            var pom = true;

            if (frmAddTeam.TxtName.Text.Length < 3)
            {
                frmAddTeam.TxtName.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }

            if (frmAddTeam.TxtCity.Text.Any(char.IsDigit))
            {
                frmAddTeam.TxtCity.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }

            if (frmAddTeam.TxtColor.Text.Any(char.IsDigit))
            {
                frmAddTeam.TxtColor.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }

            if (!pom)
            {
                MessageBox.Show("Name need to have at least 3 characters, city and color can't contain numeric values.");
            }

            return succ;
        }

        internal void AddTeam()
        {
            if (!Validation()) return;

            var newTeam = new Team(frmAddTeam.TxtName.Text, frmAddTeam.TxtCity.Text, frmAddTeam.TxtColor.Text);

            if(Communication.Instance.SaveDeleteUpdate(Operation.AddTeam, newTeam))
            {
                MessageBox.Show($"Team {newTeam.Name} is added.");
                Dispose();
            }
            else
                MessageBox.Show($"Team {newTeam.Name} is not added.");
        }
    }
}
