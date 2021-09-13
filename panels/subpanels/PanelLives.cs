using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOR4VSChat.panels.subpanels
{
    public partial class PanelLives : Form
    {
        MainWindow _mainwindow;
        public PanelLives(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        private void PanelLives_MouseDown(object sender, MouseEventArgs e)
        {
            _mainwindow.lastLocation = e.Location;
        }

        private void PanelLives_MouseMove(object sender, MouseEventArgs e)
        {
            _mainwindow.MoveWindow(e);
        }

        public int GetCooldown(string item)
        {
            decimal cooldown = 0;
            switch (item)
            {
                case "life":
                    cooldown = txt_life_cooldown.Value;
                    break;
                case "star":
                    cooldown = txt_star_cooldown.Value;
                    break;

            }
            return (int)cooldown;
        }
    }
}
