using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Forms;
using Microsoft.SqlServer.Server;

namespace Cape_Senior_Center_Inventory_System
{
    public partial class MainWindow : Form
    {
        protected IController controller;
        public List<MasterInventory> MasterList = new List<MasterInventory>();
        public List<InventoryHistory> InventoryHistory = new List<InventoryHistory>();
        public DataContext.DataContext context = new DataContext.DataContext();
        public int previousUnits = 0;
        public int editId = 0;
        public bool masterFilter = false;
        public List<string> typeFilterIndex;
        public string[] columnNames;
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
            InventoryHistory = context.InventoryHistory.ToList();
            currentInventoryView.DataSource = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            inventoryHistoryDataGridView.DataSource = context.InventoryHistory.Where(x => x.Updated_TS < DateTime.Now).ToList();
            masterListView.DataSource = context.MasterInventories.ToList();
            setupColors();
            typeFilterBox.Items.AddRange(context.ItemType.Select(x => x.Description).ToArray());
            columnNames = typeof(MasterInventory).GetProperties()
                .Select(property => property.Name)
                .ToArray();
            columnFilter.Items.AddRange(columnNames);
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

        private void inventoryHistoryStartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (inventoryHistoryStartDatePicker.Value > inventoryHistoryEndDatePicker.Value)
            {
                MessageBox.Show("Start date cannot be after end date!", "Date Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            refreshHistory(inventoryHistoryDataGridView, context.InventoryHistory.Where(x => x.Updated_TS >= inventoryHistoryStartDatePicker.Value && x.Updated_TS <= inventoryHistoryEndDatePicker.Value).ToList());
        }

        private void inventoryHistoryEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (inventoryHistoryEndDatePicker.Value < inventoryHistoryStartDatePicker.Value)
            {
                MessageBox.Show("End date cannot be before start date!", "Date Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            refreshHistory(inventoryHistoryDataGridView, context.InventoryHistory.Where(x => x.Updated_TS >= inventoryHistoryStartDatePicker.Value && x.Updated_TS <= inventoryHistoryEndDatePicker.Value).ToList());
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
            addHistory(editId, previousUnits);
            context.SaveChanges();
            refreshView(currentInventoryView, context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList());
            refreshView(masterListView, context.MasterInventories.ToList());
        }

        public void addHistory(int id, int previousUnits)
        {
            var data = context.MasterInventories.Where(x => x.Id == id).ToList();
            context.InventoryHistory.Add(new InventoryHistory()
            {
                ItemId = data[0].Id,
                ItemName = data[0].ItemName,
                PreviousUnitsOnHand = previousUnits,
                NewUnitsOnHand = data[0].UnitsOnHand,
                Updated_TS = DateTime.Now
            });
            context.SaveChanges();
            refreshHistory(inventoryHistoryDataGridView, context.InventoryHistory.Where(x => x.Updated_TS < DateTime.Now).ToList());
        }

        private void addRow_Click(object sender, EventArgs e)
        {
        //    context.MasterInventories.Add(new MasterInventory()
        //    {
        //        ItemType = "",
        //        Brand = "",
        //        SKU = "",
        //        UnitsOnHand = 0,
        //        ItemName = "",
        //        PriceUnit = 0.00,
        //        UnitPrice = 0.00,
        //        ExtendedPrice = 0.00,
        //        Created_TS = DateTime.Now,
        //        Updated_TS = DateTime.Now,
        //    });
        //    context.SaveChanges();
        //    refreshView(masterListView, context.MasterInventories.ToList());
        //    MasterList = context.MasterInventories.ToList();
            var popup = new AddInventory();
            popup.ShowDialog();
            refreshView(currentInventoryView, context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList());
            refreshView(masterListView, context.MasterInventories.ToList());
            refreshHistory(inventoryHistoryDataGridView, context.InventoryHistory.Where(x => x.Updated_TS < DateTime.Now).ToList());
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

        private void refreshHistory(DataGridView refresh, List<InventoryHistory> dataSource)
        {
            // Fixes end edit data refresh issue. Causes row one to select. (related to grid refresh?)
            BeginInvoke(new MethodInvoker(() =>
            {
                refresh.DataSource = dataSource;
                refresh.Refresh();
                setupColors();
            }));
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

        private void inventoryHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_MasterInventory_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editId = (int)masterListView.Rows[e.RowIndex].Cells[0].Value;
            previousUnits = (int)masterListView.Rows[e.RowIndex].Cells[4].Value;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!masterFilter)
            {
                masterListView.Location = new Point(3, 100);
                typeLabel.Visible = true;
                typeFilterBox.Visible = true;
                termsLabel.Visible = true;
                termsTextBox.Visible = true;
                columnFilter.Visible = true;
                clearButton.Visible = true;          
                masterFilter = true;
            }
            else
            {
                masterListView.Location = new Point(3, 43);
                typeLabel.Visible = false;
                typeFilterBox.Visible = false;
                termsLabel.Visible = false;
                termsTextBox.Visible = false;
                columnFilter.Visible = false;
                clearButton.Visible = false;
                masterFilter = false;
            }

        }

        private void typeFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshView(masterListView, context.MasterInventories.Where(x => x.ItemType == typeFilterBox.Text).ToList());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            typeFilterBox.Text = "";
            termsTextBox.Text = "";
            columnFilter.Text = "";
            columnFilter.Enabled = false;
            refreshView(masterListView, context.MasterInventories.ToList());
        }

        private void columnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MasterInventory> query = new List<MasterInventory>();
            string caseSwitch = columnFilter.Text;
            switch(caseSwitch)
            {
                case "Id":
                    query = context.MasterInventories.Where(x => x.Id.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
                case "ItemType":
                    query = context.MasterInventories.Where(x => x.ItemType.Contains(termsTextBox.Text)).ToList();
                    break;
                case "Brand":
                    query = context.MasterInventories.Where(x => x.Brand.Contains(termsTextBox.Text)).ToList();
                    break;
                case "SKU":
                    query = context.MasterInventories.Where(x => x.SKU.Contains(termsTextBox.Text)).ToList();
                    break;
                case "UnitsOnHand":
                    query = context.MasterInventories.Where(x => x.UnitsOnHand.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
                case "ItemName":
                    query = context.MasterInventories.Where(x => x.ItemName.Contains(termsTextBox.Text)).ToList();
                    break;
                case "PriceUnit":
                    query = context.MasterInventories.Where(x => x.PriceUnit.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
                case "UnitPrice":
                    query = context.MasterInventories.Where(x => x.UnitPrice.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
                case "ExtendedPrice":
                    query = context.MasterInventories.Where(x => x.ExtendedPrice.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
                case "Created_TS":
                    query = context.MasterInventories.Where(x => x.Created_TS.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
                case "Updated_TS":
                    query = context.MasterInventories.Where(x => x.Updated_TS.ToString().Contains(termsTextBox.Text)).ToList();
                    break;
            }
            refreshView(masterListView, query);
        }

        private void termsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (termsTextBox.Text != "")
            {
                columnFilter.Enabled = true;
            }
            else
            {
                columnFilter.Enabled = false;
            }
        }
    }

    // TODO: Pricing Logic 
}
