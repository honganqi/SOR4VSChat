using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security;

namespace SOR4VSChat
{
    public partial class BotCredentialsForm : Form
    {
        // based on https://weblogs.asp.net/jongalloway/encrypting-passwords-in-a-net-app-config-file
        private MainWindow _mainwindow;

        public BotCredentialsForm(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        public void FillBotSettings(Dictionary<string, string> settings)
        {
            txtOAuth.Text = settings["botToken"];
            txtBotNick.Text = settings["botNick"];
            txtChannelName.Text = settings["channelName"];
            txtNowOnline.Text = settings["notifNowOnline"];
            txtNoGameYet.Text = settings["notifNoGameYet"];
            if (settings["botRepliesToFile"] == "True")
            {
                chkBotRepliesToFile.Checked = true;
            }
            else
            {
                chkBotRepliesToFile.Checked = false;
            }
        }

        public Dictionary<string, string> BotCredentials()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>
            {
                ["botToken"] = txtOAuth.Text,
                ["botNick"] = txtBotNick.Text,
                ["channelName"] = txtChannelName.Text,
                ["notifNowOnline"] = txtNowOnline.Text,
                ["notifNoGameYet"] = txtNoGameYet.Text,
                ["botRepliesToFile"] = chkBotRepliesToFile.Checked.ToString(),
            };
            return settings;
        }

        private void btnSaveBotSettings_Click(object sender, EventArgs e)
        {
            _mainwindow.SaveSettings();
        }

        private void btnShowOAuth_Click(object sender, EventArgs e)
        {
            if (txtOAuth.PasswordChar == '*')
            {
                txtOAuth.PasswordChar = new char();
                btnShowOAuth.Text = "Hide Token";
            } else
            {
                txtOAuth.PasswordChar = '*';
                btnShowOAuth.Text = "Show Token";
            }
        }

        private void labelLinkTwitchApps_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi");
        }

        private void labelLinkTwitchApps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi");
        }

        private void BotCredentialsForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mainwindow.lastLocation = e.Location;
        }

        private void BotCredentialsForm_MouseMove(object sender, MouseEventArgs e)
        {
            _mainwindow.MoveWindow(e);
        }
    }
}
