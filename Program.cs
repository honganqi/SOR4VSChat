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
            if (System.IO.File.Exists("SOR4VSChatLib.dll"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            else
            {
                DialogResult downloadAsk = MessageBox.Show("SOR4VSChatLib.dll does not exist. The app will now download the file from https://sidestream.tk/scoreattack. \n\nDo you wish to do this?", "SOR4VSChatLib.dll is Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (downloadAsk == DialogResult.Yes)
                {
                    using (var client = new System.Net.WebClient())
                    {
                        client.DownloadFile("https://sidestream.tk/scoreattack/SOR4VSChatLib.dll", "SOR4VSChatLib.dll");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to proceed. Get the \"SOR4VSChatLib.dll\" file or a cat will become sad.\n\nPlease visit https://sourceforge.net/p/sor4-vs-chat/ for more details.", "SOR4VSChatLib.dll is Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
        }
    }
}