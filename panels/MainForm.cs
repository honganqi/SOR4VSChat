using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOR4VSChat
{
    public partial class MainForm : Form
    {
        private MainWindow _mainwindow;
        public panels.subpanels.PanelLives panelLives;
        public panels.subpanels.PanelSpeed panelSpeed;
        public panels.subpanels.PanelSize panelSize;
        public panels.subpanels.PanelHealth panelHealth;
        public panels.subpanels.PanelGravity panelGravity;
        public panels.subpanels.PanelSpawns panelSpawns;
        public panels.subpanels.PanelCharacters panelCharacters;


        public MainForm(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;

            btnStartBot.Text = "\u25B6 START BOT";
            panelLives = new panels.subpanels.PanelLives(mainwindow) { TopLevel = false, TopMost = true };
            panelSpeed = new panels.subpanels.PanelSpeed(mainwindow) { TopLevel = false, TopMost = true };
            panelSize = new panels.subpanels.PanelSize(mainwindow) { TopLevel = false, TopMost = true };
            panelHealth = new panels.subpanels.PanelHealth(mainwindow) { TopLevel = false, TopMost = true };
            panelGravity = new panels.subpanels.PanelGravity(mainwindow) { TopLevel = false, TopMost = true };
            panelSpawns = new panels.subpanels.PanelSpawns(mainwindow) { TopLevel = false, TopMost = true };
            panelCharacters = new panels.subpanels.PanelCharacters(mainwindow) { TopLevel = false, TopMost = true };

        }

        public void SwitchPanel(string panelname)
        {
            chatPanel.Visible = false;
            chatPanel.Controls.Clear();
            switch (panelname)
            {
                case "lives":
                    chatPanel.Controls.Add(panelLives);
                    panelLives.Show();
                    break;
                case "speed":
                    chatPanel.Controls.Add(panelSpeed);
                    panelSpeed.Show();
                    break;
                case "size":
                    chatPanel.Controls.Add(panelSize);
                    panelSize.Show();
                    break;
                case "health":
                    chatPanel.Controls.Add(panelHealth);
                    panelHealth.Show();
                    break;
                case "gravity":
                    chatPanel.Controls.Add(panelGravity);
                    panelGravity.Show();
                    break;
                case "character":
                    chatPanel.Controls.Add(panelCharacters);
                    panelCharacters.Show();
                    break;
            }
            chatPanel.Visible = true;
        }

        private async void btnStartBot_Click(object sender, EventArgs e)
        {
            if (_mainwindow.CheckSettings())
            {
                await _mainwindow.StartBot();
            }
        }

        public void UpdateUI(string mode)
        {
            switch (mode)
            {
                case "start":
                    btnStartBot.Enabled = false;
                    break;
                default:
                    btnStartBot.Enabled = true;
                    break;
            }
            
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            _mainwindow.SaveSettings();
        }

        private void btnBotSettings_Click(object sender, EventArgs e)
        {
            _mainwindow.SwitchPanel("botcredentials");
        }

        private void btnToggleCommandLog_Click(object sender, EventArgs e)
        {
            if (_mainwindow.chatWindow.Visible)
            {
                _mainwindow.chatWindow.Visible = false;
                btnToggleCommandLog.Text = "Show Command Log";
            }
            else
            {
                _mainwindow.chatWindow.Visible = true;
                btnToggleCommandLog.Text = "Hide Command Log";
            }
        }
    }
}
