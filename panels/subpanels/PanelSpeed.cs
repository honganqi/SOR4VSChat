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
    public partial class PanelSpeed : Form
    {
        MainWindow _mainwindow;
        public PanelSpeed(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        private void PanelSpeed_MouseDown(object sender, MouseEventArgs e)
        {
            _mainwindow.lastLocation = e.Location;
        }

        private void PanelSpeed_MouseMove(object sender, MouseEventArgs e)
        {
            _mainwindow.MoveWindow(e);
        }
        public int GetCooldown()
        {
            decimal cooldown = txt_speed_cooldown.Value;
            return (int)cooldown;
        }
    }
}
