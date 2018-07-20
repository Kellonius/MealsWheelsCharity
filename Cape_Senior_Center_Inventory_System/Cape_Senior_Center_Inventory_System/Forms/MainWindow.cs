using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cape_Senior_Center_Inventory_System
{
    public partial class MainWindow : Form
    {
        protected IController controller;
        public MainWindow(IController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }
        public void MainWindow_Load(object sender, EventArgs e)
        {
            bsCurrentInventory.DataSource = controller.InventoryModels;
            bsMasterInventory.DataSource = controller.InventoryModels;

            invNotifications.SelectionStart = invNotifications.TextLength;
            invNotifications.SelectionLength = 0;
            //call setColors() once you have data from db
        }

        public void setColors(string item, int amount)
        {
            invNotifications.SelectionColor = Color.Black;
            invNotifications.AppendText(item + ":");
            var myswitch = new Dictionary<Func<int, bool>, Action>
            {
            { x => x == 0 ,    () => invNotifications.SelectionColor = Color.Red},
            { x => x <= 5 ,    () => invNotifications.SelectionColor = Color.Orange},
            { x => x <= 10 ,    () => invNotifications.SelectionColor = Color.Gold},
            };

            myswitch.First(sw => sw.Key(amount)).Value();
            invNotifications.AppendText(" " + amount.ToString());
            invNotifications.SelectionColor = Color.Black;
            invNotifications.AppendText(" left in inventory\n");
            invNotifications.SelectionColor = invNotifications.ForeColor;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            addRecipePanel.Visible = true;
        }

        private void exitAddRecipePanelButton_Click(object sender, EventArgs e)
        {
            addRecipePanel.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
