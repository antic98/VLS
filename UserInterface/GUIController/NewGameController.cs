using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserInterface.Dialogs.GameDialogs;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class NewGameController
    {
        private readonly FrmScheduleGame frmScheduleGame;

        public NewGameController(FrmScheduleGame frmScheduleGame)
        {
            this.frmScheduleGame = frmScheduleGame;
        }

        internal void Init()
        {
            frmScheduleGame.CmbHost.DataSource = Controller.GetAllTeams();
            frmScheduleGame.CmbGuest.DataSource = Controller.GetAllTeams();
        }

        private bool Validation()
        {
            bool succ = true;

            frmScheduleGame.CmbHost.BackColor = Color.FromArgb(45, 66, 91);
            frmScheduleGame.CmbGuest.BackColor = Color.FromArgb(45, 66, 91);
            frmScheduleGame.LblDateError.Text = "";

            if (frmScheduleGame.CmbHost.SelectedIndex == -1)
            {
                frmScheduleGame.CmbHost.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmScheduleGame.CmbGuest.SelectedIndex == -1)
            {
                frmScheduleGame.CmbGuest.BackColor = Color.YellowGreen;
                succ = false;
            }

            if (frmScheduleGame.CmbHost.SelectedIndex == frmScheduleGame.CmbGuest.SelectedIndex)
            {
                frmScheduleGame.CmbHost.BackColor = Color.YellowGreen;
                frmScheduleGame.CmbGuest.BackColor = Color.YellowGreen;
                succ = false;
            }

            DateTime date = frmScheduleGame.DtpDate.Value;

            if (date < DateTime.Now)
            {
                frmScheduleGame.LblDateError.Text = "Date has to be in future.";
                succ = false;
            }

            return succ;
        }

        private void Dispose()
        {
            frmScheduleGame.Dispose();
        }

        internal void ScheduleGame()
        {
            if (!Validation()) return;

            var newGame = new Game(frmScheduleGame.CmbHost.SelectedItem as Team,
                frmScheduleGame.CmbGuest.SelectedItem as Team,
                frmScheduleGame.DtpDate.Value)
            {
                Round = (int)frmScheduleGame.NumericRound.Value
            };

            if (Communication.Instance.SaveDeleteUpdate(Operation.AddGame, newGame))
            {
                MessageBox.Show("Game " + newGame.Host.Name + " vs " + newGame.Guest.Name + " is scheduled!");
                Dispose();
            }
            else
                MessageBox.Show("Game " + newGame.Host.Name + " vs " + newGame.Guest.Name + " is not scheduled!");
            
        }
    }
}
