using Beep.Beep.Dealership.App.Core;
using Beep.Beep.Dealership.App.Core.Entities;
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
    public partial class Add : KryptonForm
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            updateStatus();
            this.TopMost = true;
            this.BringToFront();
        }

        private void updateStatus(String status = null)
        {
            if (string.IsNullOrEmpty(status))
                this.statusLabel.Text = string.Empty;
            else
                this.statusLabel.Text = status;
        }

        private void toggleSubmitButton()
        {
            if (string.IsNullOrEmpty(this.makeBox.Text) ||
                string.IsNullOrEmpty(this.modelBox.Text) ||
                string.IsNullOrEmpty(this.colorBox.Text) ||
                string.IsNullOrEmpty(this.yearBox.Text) ||
                string.IsNullOrEmpty(this.priceBox.Text))
                this.submitButton.Enabled = false;
            else
                this.submitButton.Enabled = true;
        }

        private void makeBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private void modelBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (await Database.SaveAnItem(new Vehicle()
                {
                    Name = "unknown",
                    Make = makeBox.Text,
                    Model = modelBox.Text,
                    Color = colorBox.Text,
                    Year = UInt32.Parse(yearBox.Text),
                    Price = Double.Parse(priceBox.Text),
                    Sold = false
                }))
                    updateStatus("Successfully added car!");
                else
                    updateStatus("Failed to add new car!");
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString());  updateStatus("Failed to add new car!"); }
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as KryptonTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
