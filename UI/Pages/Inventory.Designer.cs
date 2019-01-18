namespace Beep.Beep.Dealership.App.UI.Pages
{
    partial class Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.frame = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.splitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.searchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.sellButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lineSeparator = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.searchLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.userMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEventLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainView = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.viewImages = new System.Windows.Forms.ImageList(this.components);
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            this.frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineSeparator)).BeginInit();
            this.userMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.Controls.Add(this.splitContainer);
            this.frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(600, 400);
            this.frame.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.searchButton);
            this.splitContainer.Panel1.Controls.Add(this.sellButton);
            this.splitContainer.Panel1.Controls.Add(this.deleteButton);
            this.splitContainer.Panel1.Controls.Add(this.addButton);
            this.splitContainer.Panel1.Controls.Add(this.lineSeparator);
            this.splitContainer.Panel1.Controls.Add(this.searchBox);
            this.splitContainer.Panel1.Controls.Add(this.searchLabel);
            this.splitContainer.Panel1.Controls.Add(this.userMenu);
            this.splitContainer.Panel1MinSize = 0;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.mainView);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(600, 400);
            this.splitContainer.SplitterDistance = 595;
            this.splitContainer.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(77, 156);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(440, 25);
            this.searchButton.TabIndex = 6;
            this.searchButton.Values.Text = "SEARCH";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sellButton.Enabled = false;
            this.sellButton.Location = new System.Drawing.Point(77, 297);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(440, 25);
            this.sellButton.TabIndex = 5;
            this.sellButton.Values.Text = "SELL";
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(77, 266);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(440, 25);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Values.Text = "DELETE";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(77, 235);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(440, 25);
            this.addButton.TabIndex = 3;
            this.addButton.Values.Text = "ADD";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lineSeparator
            // 
            this.lineSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.lineSeparator.DrawMoveIndicator = false;
            this.lineSeparator.Location = new System.Drawing.Point(77, 195);
            this.lineSeparator.Name = "lineSeparator";
            this.lineSeparator.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.lineSeparator.Size = new System.Drawing.Size(440, 24);
            this.lineSeparator.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(77, 126);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(440, 23);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchLabel.Location = new System.Drawing.Point(240, 100);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(115, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Values.Text = "Search In Inventory";
            // 
            // userMenu
            // 
            this.userMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.userMenu.Location = new System.Drawing.Point(0, 0);
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(595, 24);
            this.userMenu.TabIndex = 7;
            this.userMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEventLogsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.DropDownOpening += new System.EventHandler(this.helpToolStripMenuItem_DropDownOpening);
            // 
            // openEventLogsToolStripMenuItem
            // 
            this.openEventLogsToolStripMenuItem.Enabled = false;
            this.openEventLogsToolStripMenuItem.Name = "openEventLogsToolStripMenuItem";
            this.openEventLogsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openEventLogsToolStripMenuItem.Text = "Open event logs";
            this.openEventLogsToolStripMenuItem.Click += new System.EventHandler(this.openEventLogsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainView
            // 
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.ImageIndex = 0;
            this.mainView.ImageList = this.viewImages;
            this.mainView.Location = new System.Drawing.Point(0, 0);
            this.mainView.Name = "mainView";
            this.mainView.SelectedImageIndex = 0;
            this.mainView.Size = new System.Drawing.Size(0, 400);
            this.mainView.TabIndex = 0;
            this.mainView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainView_AfterSelect);
            // 
            // viewImages
            // 
            this.viewImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("viewImages.ImageStream")));
            this.viewImages.TransparentColor = System.Drawing.Color.Transparent;
            this.viewImages.Images.SetKeyName(0, "search.png");
            this.viewImages.Images.SetKeyName(1, "info.png");
            this.viewImages.Images.SetKeyName(2, "error.png");
            this.viewImages.Images.SetKeyName(3, "warning.png");
            this.viewImages.Images.SetKeyName(4, "car.png");
            this.viewImages.Images.SetKeyName(5, "factory.png");
            this.viewImages.Images.SetKeyName(6, "model.png");
            this.viewImages.Images.SetKeyName(7, "calendar.png");
            this.viewImages.Images.SetKeyName(8, "palette.png");
            this.viewImages.Images.SetKeyName(9, "name.png");
            this.viewImages.Images.SetKeyName(10, "price-tag.png");
            this.viewImages.Images.SetKeyName(11, "money.png");
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.frame);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            this.frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineSeparator)).EndInit();
            this.userMenu.ResumeLayout(false);
            this.userMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel frame;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sellButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator lineSeparator;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel searchLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView mainView;
        private System.Windows.Forms.ImageList viewImages;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.MenuStrip userMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEventLogsToolStripMenuItem;
    }
}
