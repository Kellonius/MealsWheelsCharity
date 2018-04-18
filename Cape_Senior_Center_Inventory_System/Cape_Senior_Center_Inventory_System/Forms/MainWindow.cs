using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cape_Senior_Center_Inventory_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void MainWindow_Load(object sender, EventArgs e)
        {
            invNotifications.SelectionStart = invNotifications.TextLength;
            invNotifications.SelectionLength = 0;
            setColors("Green Beans", 3);
            setColors("Bread", 10);
            setColors("Chicken Breast", 0);
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

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentInventory currentInventory = new CurrentInventory();
            if (Application.OpenForms.OfType<CurrentInventory>().Count() == 1)
            {
                Application.OpenForms["currentInventory"].BringToFront();
            }
            else
            {
                currentInventory.Show();
            }
        }

        private void masterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterInventory masterInventory = new MasterInventory();
            if (Application.OpenForms.OfType<MasterInventory>().Count() == 1)
            {
                Application.OpenForms["masterInventory"].BringToFront();
            }
            else
            {
                masterInventory.Show();
            }
        }

        private void reconcileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceReconcile priceReconcile = new PriceReconcile();
            if (Application.OpenForms.OfType<PriceReconcile>().Count() == 1)
            {
                Application.OpenForms["priceReconcile"].BringToFront();
            }
            else
            {
                priceReconcile.Show();
            }
        }

        private void reconcileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HistoryReconcile historyReconcile = new HistoryReconcile();
            if (Application.OpenForms.OfType<HistoryReconcile>().Count() == 1)
            {
                Application.OpenForms["historyReconcile"].BringToFront();
            }
            else
            {
                historyReconcile.Show();
            }
        }

        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HistoryInventory historyInventory = new HistoryInventory();
            if (Application.OpenForms.OfType<HistoryInventory>().Count() == 1)
            {
                Application.OpenForms["historyInventory"].BringToFront();
            }
            else
            {
                historyInventory.Show();
            }
        }

        private void recipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes();
            if (Application.OpenForms.OfType<HistoryInventory>().Count() == 1)
            {
                Application.OpenForms["recipes"].BringToFront();
            }
            else
            {
                recipes.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Recipe for Bacon and Eggs\nIngredients:\nEggs: 1\nBacon: 1\n\nScramble Eggs medium heat for 4 minutes.\nBake Bacon at 375 for 17 minutes.");
            } else if (listBox1.SelectedIndex == 1){
                MessageBox.Show("Recipe for Avocado Toast\nIngredients:\nBread: 2\nAvocado: 1\n\nToast Bread.\nSlice Avocado and place on toast.");
            }
        }
    }
}
