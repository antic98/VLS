using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UserInterface.ServerCommunication;
using UserInterface.UserControls;

namespace UserInterface.GUIController
{
    public class MainController
    {
        private FrmMain frmMain;
        public MainController(FrmMain frmMain)
        {
            this.frmMain = frmMain;
        }
        private void ChangePanel(UserControl userControl)
        {
            frmMain.PnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            frmMain.PnlMain.Controls.Add(userControl);
        }

        internal void Init()
        {
            frmMain.Text = $"Welcome, " + Session.SessionData.Instance.User.Name + " " + Session.SessionData.Instance.User.Surname + "!";
        }

        internal void FormClosed()
        {
            try
            {
                Communication.Instance.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>>> FormClosed event >>>>>" + ex.Message);
            }
        }

        internal void OpenUCAllTeams()
        {
            ChangePanel(new UCAllTeams());
        }

        internal void OpenUCScheduleGame()
        {
            ChangePanel(new UCScheduleGame());
        }

        internal void OpenUCAllPlayers()
        {
            ChangePanel(new UCAllPlayers());
        }

        internal void OpenUCResults()
        {
            ChangePanel(new UCResults());
        }

        internal void OpenUCTableTeams()
        {
            ChangePanel(new UCTableTeams());
        }

        internal void OpenUCTablePlayers()
        {
            ChangePanel(new UCTablePlayers());
        }
    }
}
