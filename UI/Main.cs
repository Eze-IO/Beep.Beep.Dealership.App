using Beep.Beep.Dealership.App.Core;
using Beep.Beep.Dealership.App.Core.Entities;
using Beep.Beep.Dealership.App.UI.Pages;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beep.Beep.Dealership.App.UI
{
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();

            //Set title
            this.Text = Information.Title;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Set variables
            PageManager.Instance = this;

            //Load login page
            PageManager.SwitchToLoginPage();
        }
    }
}
