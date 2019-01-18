namespace Beep.Beep.Dealership.App.UI
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.frame = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.mainHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.descriptionFrame = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumb();
            this.descriptionText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            this.frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.Controls.Add(this.descriptionText);
            this.frame.Controls.Add(this.descriptionFrame);
            this.frame.Controls.Add(this.mainHeader);
            this.frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(334, 136);
            this.frame.TabIndex = 0;
            // 
            // mainHeader
            // 
            this.mainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeader.Location = new System.Drawing.Point(0, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(334, 31);
            this.mainHeader.TabIndex = 0;
            this.mainHeader.Values.Description = "";
            this.mainHeader.Values.Heading = "--";
            this.mainHeader.Values.Image = ((System.Drawing.Image)(resources.GetObject("mainHeader.Values.Image")));
            // 
            // descriptionFrame
            // 
            this.descriptionFrame.AutoSize = false;
            this.descriptionFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionFrame.Location = new System.Drawing.Point(0, 31);
            this.descriptionFrame.Name = "descriptionFrame";
            // 
            // 
            // 
            this.descriptionFrame.RootItem.ShortText = "Root";
            this.descriptionFrame.Size = new System.Drawing.Size(334, 105);
            this.descriptionFrame.TabIndex = 1;
            // 
            // descriptionText
            // 
            this.descriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionText.Location = new System.Drawing.Point(0, 31);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(334, 105);
            this.descriptionText.TabIndex = 2;
            this.descriptionText.Values.Text = "kryptonLabel1";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 136);
            this.Controls.Add(this.frame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel frame;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader mainHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonBreadCrumb descriptionFrame;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel descriptionText;
    }
}