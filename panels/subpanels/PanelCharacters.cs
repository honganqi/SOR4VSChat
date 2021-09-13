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
    public partial class PanelCharacters : Form
    {
        MainWindow _mainwindow;
        public PanelCharacters(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        private void PanelGravity_MouseDown(object sender, MouseEventArgs e)
        {
            _mainwindow.lastLocation = e.Location;
        }

        private void PanelGravity_MouseMove(object sender, MouseEventArgs e)
        {
            _mainwindow.MoveWindow(e);
        }

        public int GetCooldown(string item)
        {
            decimal cooldown = 0;
            switch (item)
            {
                case "character":
                    cooldown = txt_char_cooldown.Value;
                    break;
                case "moves":
                    cooldown = txt_moves_cooldown.Value;
                    break;

            }
            return (int)cooldown;
        }
    }
}
