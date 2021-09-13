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
    public partial class PanelGravity : Form
    {
        MainWindow _mainwindow;
        public PanelGravity(MainWindow mainwindow)
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

        public int GetCooldown()
        {
            decimal cooldown = txt_gravity_cooldown.Value;
            return (int)cooldown;
        }
    }
}
