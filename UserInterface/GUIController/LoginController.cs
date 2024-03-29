﻿using Domain;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using UserInterface.Exceptions;
using UserInterface.ServerCommunication;

namespace UserInterface.GUIController
{
    public class LoginController
    {
        private readonly FrmLogin frmLogin;

        public LoginController(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
        }

        private bool Validation()
        {
            var succ = true;

            if (frmLogin.TxtUsername.Text == "")
            {
                frmLogin.TxtUsername.BackColor = Color.YellowGreen;
                succ = false;
            }
            else
            {
                frmLogin.TxtUsername.BackColor = Color.FromArgb(45,66,91);
            }
            if (frmLogin.TxtPassword.Text == "")
            {
                frmLogin.TxtPassword.BackColor = Color.YellowGreen;
                succ = false;
            }
            else
            {
                frmLogin.TxtPassword.BackColor = Color.FromArgb(45, 66, 91); ;
            }
            return succ;
        }
        
        internal void Login()
        {
            if (!Validation())
            {
                return;
            }

            try
            {
                User user = new User()
                {
                    Username = frmLogin.TxtUsername.Text,
                    Password = frmLogin.TxtPassword.Text
                };

                Communication.Instance.Connect();
                Communication.Instance.Login(user);

                if (Session.SessionData.Instance.User != null)
                {
                    MessageBox.Show($"Welcome, {Session.SessionData.Instance.User.Name} {Session.SessionData.Instance.User.Surname}!");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException)
            {
                MessageBox.Show("Can't connect to server!");
            }
        }


    }
}
