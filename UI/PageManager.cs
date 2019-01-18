using Beep.Beep.Dealership.App.UI.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beep.Beep.Dealership.App.UI
{
    public static class PageManager
    {
        public static Form Instance { set; get; }
        private static Inventory invetoryPage = new Inventory();
        private static Login loginPage = new Login();

        public static void SwitchToLoginPage()
        {
            if(Instance != null)
            {
                loginPage = new Login();
                if (!Instance.Controls.Contains(loginPage))
                    Instance.Controls.Add(loginPage);

                loginPage.BringToFront();
            }
        }

        public static void SwitchToInventoryPage()
        {
            if (Instance != null)
            {
                if (!Instance.Controls.Contains(invetoryPage))
                    Instance.Controls.Add(invetoryPage);

                invetoryPage.BringToFront();
            }
        }
    }
}
