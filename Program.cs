using System;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using AsyncAwaitBestPractices;

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOR4VSChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}