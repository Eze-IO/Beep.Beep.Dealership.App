using Beep.Beep.Dealership.App.Core;
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
    public partial class About : KryptonForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = this.MaximumSize;
            this.mainHeader.Text = Information.Title;
            this.descriptionText.Text = Information.CompanyInfo;
        }
    }
}
