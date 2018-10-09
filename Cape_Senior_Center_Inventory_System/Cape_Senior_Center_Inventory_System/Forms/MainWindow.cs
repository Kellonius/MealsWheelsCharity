using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cape_Senior_Center_Inventory_System.DataContext.Models;

namespace Cape_Senior_Center_Inventory_System
{
    public partial class MainWindow : Form
    {
        protected IController controller;
        public List<MasterInventory> MasterList = new List<MasterInventory>();
        public DataContext.DataContext context = new DataContext.DataContext();
        public MainWindow(IController controller)
        {

            this.controller = controller;
            InitializeComponent();
        }
        public void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.MasterInventories' table. You can move, or remove it, as needed.
            masterInventoriesTableAdapter.Fill(databaseDataSet.MasterInventories);
            MasterList = context.MasterInventories.ToList();
            currentInventoryView.DataSource = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            masterListView.DataSource = context.MasterInventories.ToList();
            setupColors();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CurrentInventory_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var data = currentInventoryView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            cellEndEdit(data, e);
        }

        private void DataGridView2_MasterInventory_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var data = masterListView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            cellEndEdit(data, e);
        }

        private void cellEndEdit(string rowData, DataGridViewCellEventArgs e)
        {
            var data = rowData;
            double dataDouble = 0.00;
            double.TryParse(data, out dataDouble);
            int caseSwitch = e.ColumnIndex;
            switch (caseSwitch)
            {
                case 0:
                    break;
                case 1:
                    MasterList[e.RowIndex].ItemType = data;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 2:
                    MasterList[e.RowIndex].Brand = data;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 3:
                    MasterList[e.RowIndex].SKU = data;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 4:
                    MasterList[e.RowIndex].UnitsOnHand = Convert.ToInt32(data);
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 5:
                    MasterList[e.RowIndex].ItemName = data;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 6:
                    MasterList[e.RowIndex].PriceUnit = dataDouble;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 7:
                    MasterList[e.RowIndex].UnitPrice = dataDouble;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;
                case 8:
                    MasterList[e.RowIndex].ExtendedPrice = dataDouble;
                    MasterList[e.RowIndex].Updated_TS = DateTime.Now;
                    break;

            }

            context.SaveChanges();
            refreshView(currentInventoryView, context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList());
            refreshView(masterListView, context.MasterInventories.ToList());
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            context.MasterInventories.Add(new MasterInventory()
            {
                ItemType = "",
                Brand = "",
                SKU = "",
                UnitsOnHand = 0,
                ItemName = "",
                PriceUnit = 0.00,
                UnitPrice = 0.00,
                ExtendedPrice = 0.00,
                Created_TS = DateTime.Now,
                Updated_TS = DateTime.Now,
            });
            context.SaveChanges();
            refreshView(masterListView, context.MasterInventories.ToList());
            MasterList = context.MasterInventories.ToList();
        }

        private void refreshView(DataGridView refresh, List<MasterInventory> dataSource)
        {
            // Fixes end edit data refresh issue. Causes row one to select. (related to grid refresh?)
            BeginInvoke(new MethodInvoker(() =>
            {
                refresh.DataSource = dataSource;
                refresh.Refresh();
                setupColors();
            }));
        }

        private void currentInventoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setupColors()
        {
            for (int i = 0; i < currentInventoryView.Rows.Count; i++)
            {
                var cell = currentInventoryView.Rows[i].Cells[4];
                if ((int)cell.Value <= 5)
                {
                    cell.Style.ForeColor = Color.Red;
                    cell.Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                }
            }
        }
    }

    // TODO: Pricing Logic 
}
