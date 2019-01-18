using ComponentFactory.Krypton.Toolkit;

namespace Beep.Beep.Dealership.App.UI
{
    partial class Sell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.customerLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.customerNameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.priceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.priceSellBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.sellButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLabel.Location = new System.Drawing.Point(13, 26);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(99, 20);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Values.Text = "Customer Name";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameBox.Location = new System.Drawing.Point(16, 52);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(285, 23);
            this.customerNameBox.TabIndex = 1;
            this.customerNameBox.TextChanged += new System.EventHandler(this.customerNameBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Location = new System.Drawing.Point(13, 84);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(87, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Values.Text = "Price to sell at";
            // 
            // priceSellBox
            // 
            this.priceSellBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceSellBox.Location = new System.Drawing.Point(16, 110);
            this.priceSellBox.Name = "priceSellBox";
            this.priceSellBox.Size = new System.Drawing.Size(285, 23);
            this.priceSellBox.TabIndex = 3;
            this.priceSellBox.TextChanged += new System.EventHandler(this.priceSellBox_TextChanged);
            this.priceSellBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceSellBox_KeyPress);
            // 
            // sellButton
            // 
            this.sellButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellButton.Location = new System.Drawing.Point(16, 188);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(285, 25);
            this.sellButton.TabIndex = 4;
            this.sellButton.Values.Text = "SUBMIT";
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(16, 153);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(20, 20);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Values.Text = "--";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.priceSellBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sell Car";
            this.Load += new System.EventHandler(this.Sell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonLabel customerLabel;
        private KryptonTextBox customerNameBox;
        private KryptonLabel priceLabel;
        private KryptonTextBox priceSellBox;
        private KryptonButton sellButton;
        private KryptonLabel statusLabel;
    }
}