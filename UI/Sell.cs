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
    public partial class Sell : KryptonForm
    {
        public Sell()
        {
            InitializeComponent();
        }

        public Sell(uint carID) : this()
        {
            this.instanceID = carID;
        }

        private uint instanceID { get; set; }

        private async void Sell_Load(object sender, EventArgs e)
        {
            updateStatus();
            var car = await Database.GetAnItem(instanceID);
            if(car!=null)
            {
                this.Text = string.Format("Sell car with ID ({0})", car.ID);
                this.priceSellBox.Text = car.Price.ToString();
            }
            this.TopMost = true;
            this.BringToFront();
        }

        private async void sellButton_Click(object sender, EventArgs e)
        {
            try
            {
                var car = await Database.GetAnItem(instanceID);
                car.Name = this.customerNameBox.Text;
                car.Price = Convert.ToUInt32(this.priceSellBox.Text);
                car.Sold = true;
                if (await Database.UpdateAnItem(car))
                {
                    updateStatus("Successfully sold car!");
                    this.sellButton.Enabled = this.customerNameBox.Enabled
                    = this.priceSellBox.Enabled = false;
                }         
                else
                {
                    updateStatus("Failed to sell car!");
                }
            }
            catch { updateStatus("Failed to sell car!"); }
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
            if (string.IsNullOrEmpty(this.customerNameBox.Text) ||
                string.IsNullOrEmpty(this.priceSellBox.Text))
                this.sellButton.Enabled = false;
            else
                this.sellButton.Enabled = true;
        }

        private void customerNameBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private void priceSellBox_TextChanged(object sender, EventArgs e)
        {
            toggleSubmitButton();
        }

        private void priceSellBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
