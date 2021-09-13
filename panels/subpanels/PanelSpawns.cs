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
    public partial class PanelSpawns : Form
    {
        MainWindow _mainwindow;
        public PanelSpawns(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        private void PanelSpawns_MouseDown(object sender, MouseEventArgs e)
        {
            _mainwindow.lastLocation = e.Location;
        }

        private void PanelSpawns_MouseMove(object sender, MouseEventArgs e)
        {
            _mainwindow.MoveWindow(e);
        }
    }
}
