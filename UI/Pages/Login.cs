using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Workspace;
using Beep.Beep.Dealership.App.Core;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Diagnostics;

namespace Beep.Beep.Dealership.App.UI.Pages
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Let page fill window
            this.Dock = DockStyle.Fill;

            //Get parent palette design & set it to the current panel
            KryptonForm parentForm = (this.Parent as KryptonForm);
            this.frame.PaletteMode = parentForm.PaletteMode;
        }

        private String Username
        {
            get
            {
                return this.usernameBox.Text;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String username = "N/A";
            if (!string.IsNullOrEmpty(Username))
                username = Username;
            Library.WriteLog(String.Format("User '{0}' has logged in!", username));
            PageManager.SwitchToInventoryPage();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openEventLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Library.Logfile))
                try
                {
                    Process.Start(Library.Logfile);
                }
                catch { return; }
        }

        private void helpToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.openEventLogsToolStripMenuItem.Enabled = File.Exists(Library.Logfile);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
