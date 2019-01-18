namespace Beep.Beep.Dealership.App.UI
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.makeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.makeBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.modelLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.modelBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.colorBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.colorLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.yearBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.yearLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.priceBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.priceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.submitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            this.makeLabel.Location = new System.Drawing.Point(13, 12);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(40, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Values.Text = "Make";
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(13, 39);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(180, 23);
            this.makeBox.TabIndex = 1;
            this.makeBox.TextChanged += new System.EventHandler(this.makeBox_TextChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.Location = new System.Drawing.Point(13, 71);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Values.Text = "Model";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(13, 97);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(180, 23);
            this.modelBox.TabIndex = 3;
            this.modelBox.TextChanged += new System.EventHandler(this.modelBox_TextChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(12, 152);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(180, 23);
            this.colorBox.TabIndex = 5;
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(12, 126);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(40, 20);
            this.colorLabel.TabIndex = 4;
            this.colorLabel.Values.Text = "Color";
            // 
            // yearBox
            // 
            this.yearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearBox.Location = new System.Drawing.Point(242, 39);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(180, 23);
            this.yearBox.TabIndex = 7;
            this.yearBox.TextChanged += new System.EventHandler(this.yearBox_TextChanged);
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearLabel.Location = new System.Drawing.Point(242, 12);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(34, 20);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Values.Text = "Year";
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.Location = new System.Drawing.Point(242, 97);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(180, 23);
            this.priceBox.TabIndex = 9;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Location = new System.Drawing.Point(242, 71);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 20);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Values.Text = "Initial Price";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(12, 224);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(409, 25);
            this.submitButton.TabIndex = 10;
            this.submitButton.Values.Text = "SUBMIT";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(12, 191);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(20, 20);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Values.Text = "--";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeBox);
            this.Controls.Add(this.makeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add To Inventory";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel makeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox makeBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel modelLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox modelBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox colorBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel colorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox yearBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel yearLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox priceBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel priceLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton submitButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel statusLabel;
    }
}