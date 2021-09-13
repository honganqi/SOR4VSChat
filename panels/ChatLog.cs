using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOR4VSChat.panels
{
    public partial class ChatLog : Form
    {
        MainWindow _mainwindow;
        public ChatLog(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;

        }

        private void ChatLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _mainwindow.mainform.btnToggleCommandLog.Text = "Show Command Log";
            this.Hide();
        }
    }
}
