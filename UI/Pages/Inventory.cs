using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Beep.Beep.Dealership.App.Core;
using Beep.Beep.Dealership.App.Core.Entities;
using System.IO;
using System.Diagnostics;

namespace Beep.Beep.Dealership.App.UI.Pages
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //Let page fill window
            this.Dock = DockStyle.Fill;

            //Disable the delete and sell button(s)
            deleteButton.Enabled = sellButton.Enabled = false;


            //Get parent palette design & set it to the current panel
            KryptonForm parentForm = (this.Parent as KryptonForm);
            this.frame.PaletteMode = parentForm.PaletteMode;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            populateView(searchBox.Text);
        }

        private String _lastSearch = null;
        private async void populateView(String filter)
        {
            try
            {
                _lastSearch = filter;
                String sName = "Search Results";
                Car[] list = await Database.SearchForItems(filter);
                clearView();
                if (this.splitContainer.SplitterDistance > (this.Width / 2))
                    this.splitContainer.SplitterDistance = (this.Width / 2);
                if (list == null)
                {
                    TreeNode treeNode = new TreeNode("Error failed to get results");
                    treeNode.ImageIndex = 2;
                    treeNode.SelectedImageIndex = 2;
                    mainView.Nodes.Add(treeNode);
                }
                else
                {
                    if (list.Length <= 0)
                        sName = "No search results for '" + filter + "'";
                    
                    List<TreeNode> array = new List<TreeNode>();
                    foreach(var c in list)
                    {
                        List<TreeNode> itemDetails = new List<TreeNode>();
                        TreeNode make = new TreeNode(String.Format("Make: {0}", c.Make));
                        make.ImageIndex = 5;
                        make.SelectedImageIndex = 5;
                        itemDetails.Add(make);
                        TreeNode model = new TreeNode(String.Format("Model: {0}", c.Model));
                        model.ImageIndex = 6;
                        model.SelectedImageIndex = 6;
                        itemDetails.Add(model);
                        TreeNode year = new TreeNode(String.Format("Year: {0}", c.Year));
                        year.ImageIndex = 7;
                        year.SelectedImageIndex = 7;
                        itemDetails.Add(year);
                        TreeNode color = new TreeNode(String.Format("Color: {0}", c.Color));
                        color.ImageIndex = 8;
                        color.SelectedImageIndex = 8;
                        itemDetails.Add(color);
                        if (c.Sold)
                        {
                            TreeNode name = new TreeNode(String.Format("Customer: {0}", c.Name));
                            name.ImageIndex = 9;
                            name.SelectedImageIndex = 9;
                            itemDetails.Add(name);
                        }
                        var x = (c.Sold ? "Sold" : "Unsold");
                        TreeNode status = new TreeNode(String.Format("Status: {0}", x));
                        status.ImageIndex = 10;
                        status.SelectedImageIndex = 10;
                        itemDetails.Add(status);
                        TreeNode price = new TreeNode(String.Format("Price: ${0:0.00}", c.Price));
                        price.ImageIndex = 11;
                        price.SelectedImageIndex = 11;
                        itemDetails.Add(price);
                        TreeNode item = new TreeNode(String.Format("ID ({0})", c.ID), itemDetails.ToArray());
                        item.ImageIndex = 4;
                        item.SelectedImageIndex = 4;
                        item.Tag = c;
                        array.Add(item);
                    }
                    TreeNode treeNode = new TreeNode(sName, array.ToArray());
                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 0;
                    treeNode.Expand();
                    mainView.Padding = new Padding(3);
                    mainView.Nodes.Add(treeNode);
                }
            }
            catch { clearView(); return; }
        }

        public void refreshView()
        {
            populateView(_lastSearch);
        }

        public void clearView()
        {
            mainView.Nodes.Clear();
        }

        private Car _lastSelectedItem = null;
        private async void mainView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Set the delete and sell button(s) to their defaults
            deleteButton.Enabled = sellButton.Enabled = false;

            /* Check to see if selected node 
               exist and enbale the sell and
               delete button(s).
            */
            TreeNode n = (e.Node as TreeNode);
            if(n.Tag!=null)
                if(n.Tag.GetType() == typeof(Car))
                {
                    Car c = (n.Tag as Car);
                    var x = await Database.GetAnItem(c.ID);
                    if (x != null)
                    {
                        _lastSelectedItem = c;
                        deleteButton.Enabled = true;
                        sellButton.Enabled = (!_lastSelectedItem.Sold);
                    }
                }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var x = await Database.RemoveAnItem(_lastSelectedItem.ID);
            if (!x)
                MessageBox.Show(string.Format("Failed to delete item ID({0})", _lastSelectedItem.ID),
                    Information.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                refreshView();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (!_lastSelectedItem.Sold)
            {
                new Sell(_lastSelectedItem.ID).ShowDialog();
                refreshView();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
            refreshView();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            PageManager.SwitchToLoginPage();
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

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ignore
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.searchButton.PerformClick();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
