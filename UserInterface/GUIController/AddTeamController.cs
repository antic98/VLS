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
using UserInterface.Dialogs.TeamDialogs;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class AddTeamController
    {
        private FrmAddTeam frmAddTeam;

        public AddTeamController(FrmAddTeam frmAddTeam)
        {
            this.frmAddTeam = frmAddTeam;
        }

        internal void Dispose()
        {
            frmAddTeam.Dispose();
        }              

        private bool Validation()
        {
            bool succ = true;

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

            bool pom = true;

            if (frmAddTeam.TxtName.Text.Length < 3)
            {
                frmAddTeam.TxtName.BackColor = Color.YellowGreen;
                succ = false;
                pom = false;
            }

            foreach(Char c in frmAddTeam.TxtCity.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmAddTeam.TxtCity.BackColor = Color.YellowGreen;
                    succ = false;
                    pom = false;
                    break;
                }
            }

            foreach (Char c in frmAddTeam.TxtColor.Text)
            {
                if (Char.IsDigit(c))
                {
                    frmAddTeam.TxtColor.BackColor = Color.YellowGreen;
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

        internal void AddTeam()
        {
            if (!Validation()) return;

            Team newTeam = new Team();
            newTeam.Name = frmAddTeam.TxtName.Text;
            newTeam.City = frmAddTeam.TxtCity.Text;
            newTeam.Color = frmAddTeam.TxtColor.Text;

            if(Communication.Instance.SaveDeleteUpdate(Operation.SaveTeam, newTeam))
            {
                MessageBox.Show($"Team {newTeam.Name} is added.");
                Dispose();
            }
            else
                MessageBox.Show($"Team {newTeam.Name} is not added.");
        }
    }
}
