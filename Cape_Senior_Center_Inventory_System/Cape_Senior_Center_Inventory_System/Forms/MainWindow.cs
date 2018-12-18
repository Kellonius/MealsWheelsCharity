﻿using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
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
        public List<MasterInventory> CurrentList = new List<MasterInventory>();
        public List<InventoryHistory> InventoryHistory = new List<InventoryHistory>();
        public DataContext.DataContext context = new DataContext.DataContext();
        public int previousUnits = 0;
        public int editId = 0;
        public int RowIndex;
        public bool masterFilter = false;
        public bool currentFilter = false;
        public bool currentInlineEdit = false;
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
            CurrentList = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            InventoryHistory = context.InventoryHistory.ToList();
            inventoryHistoryDataGridView.DataSource = context.InventoryHistory.Where(x => x.Updated_TS < DateTime.Now).ToList();
            setupGrid();
            masterListView.DataSource = context.MasterInventories.ToList();
            setupColors();
            var typeFilters = context.ItemType.Select(x => x.Description).ToArray();
            typeFilterBox.Items.AddRange(typeFilters);
            currentTypeDropdown.Items.AddRange(typeFilters);
            columnNames = typeof(MasterInventory).GetProperties()
                .Select(property => property.Name)
                .ToArray();
            columnFilter.Items.AddRange(columnNames);
            currentColumnFilter.Items.AddRange(columnNames);

        }

        #region Single Cell Edits
        private void currentInventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void masterListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void DataGridView2_MasterInventory_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editId = (int)masterListView.Rows[RowIndex].Cells[0].Value;
            previousUnits = (int)masterListView.Rows[RowIndex].Cells[5].Value;
        }

        private void currentInventoryView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editId = (int)currentInventoryView.Rows[RowIndex].Cells[0].Value;
            previousUnits = (int)currentInventoryView.Rows[RowIndex].Cells[5].Value;
        }
        private void DataGridView2_CurrentInventory_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var data = currentInventoryView.Rows[RowIndex].Cells[e.ColumnIndex].Value.ToString();
            currentInlineEdit = true;
            cellEndEdit(data, e);
        }

        private void DataGridView2_MasterInventory_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var data = masterListView.Rows[RowIndex].Cells[e.ColumnIndex].Value.ToString();
            cellEndEdit(data, e);
        }

        private void cellEndEdit(string rowData, DataGridViewCellEventArgs e)
        {
            var data = rowData;
            double dataDouble = 0.00;
            double.TryParse(data, out dataDouble);
            int caseSwitch = e.ColumnIndex;
            if (currentInlineEdit)
            {
                switch (caseSwitch)
                {
                    case 0:
                        break;
                    case 1:
                        CurrentList[RowIndex].ItemType = data;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 2:

                        CurrentList[RowIndex].SubType = data;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 3:
                        CurrentList[RowIndex].Brand = data;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 4:
                        CurrentList[RowIndex].SKU = data;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 5:
                        CurrentList[RowIndex].UnitsOnHand = Convert.ToInt32(data);
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 6:
                        CurrentList[RowIndex].UnitOfMeasure = data;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 7:
                        CurrentList[RowIndex].ItemName = data;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 8:
                        CurrentList[RowIndex].PriceUnit = dataDouble;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 9:
                        CurrentList[RowIndex].UnitPrice = dataDouble;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 10:
                        CurrentList[RowIndex].ExtendedPrice = dataDouble;
                        CurrentList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                }
            }
            else
            {

                switch (caseSwitch)
                {
                    case 0:
                        break;
                    case 1:
                        MasterList[RowIndex].ItemType = data;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 2:

                        MasterList[RowIndex].SubType = data;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 3:
                        MasterList[RowIndex].Brand = data;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 4:
                        MasterList[RowIndex].SKU = data;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 5:
                        MasterList[RowIndex].UnitsOnHand = Convert.ToInt32(data);
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 6:
                        MasterList[RowIndex].UnitOfMeasure = data;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 7:
                        MasterList[RowIndex].ItemName = data;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 8:
                        MasterList[RowIndex].PriceUnit = dataDouble;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 9:
                        MasterList[RowIndex].UnitPrice = dataDouble;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                    case 10:
                        MasterList[RowIndex].ExtendedPrice = dataDouble;
                        MasterList[RowIndex].Updated_TS = DateTime.Now;
                        break;
                }
            }
            addHistory(editId, previousUnits);
            context.SaveChanges();
            context = new DataContext.DataContext();
            MasterList = new List<MasterInventory>();
            CurrentList = new List<MasterInventory>();
            MasterList = context.MasterInventories.ToList();
            CurrentList = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            refreshView(currentInventoryView, context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList());
            refreshView(masterListView, context.MasterInventories.ToList());
        }
        #endregion

        #region Master Inventory
        private void addRow_Click(object sender, EventArgs e)
        {
            var popup = new AddInventory();
            popup.ShowDialog();
            refreshAll();
        }

        private void masterEditButton_Click(object sender, EventArgs e)
        {
            var editPopup = new AddInventory();
            editPopup.Text = "Edit Item";
            editPopup.prepareEdit(MasterList[RowIndex].Id);
            editPopup.ShowDialog();
            context = new DataContext.DataContext();
            refreshAll();
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
            MasterList = context.MasterInventories.Where(x => x.ItemType == typeFilterBox.Text).ToList();
            refreshView(masterListView, MasterList);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            typeFilterBox.Text = "";
            termsTextBox.Text = "";
            columnFilter.Text = "";
            columnFilter.Enabled = false;
            MasterList = context.MasterInventories.ToList();
            refreshView(masterListView, MasterList);
        }

        private void columnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MasterInventory> query = new List<MasterInventory>();
            foreach (var x in context.MasterInventories)
            {
                if (x.GetType().GetProperty(columnFilter.Text).GetValue(x).ToString().ToLower().Contains(termsTextBox.Text.ToLower()))
                {
                    query.Add(x);
                }
            }

            MasterList = query;
            refreshView(masterListView, MasterList);
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
        #endregion

        #region Current Inventory
        private void currentFilterButton_Click(object sender, EventArgs e)
        {
            if (!currentFilter)
            {
                currentInventoryView.Location = new Point(3, 100);
                currentTypeLabel.Visible = true;
                currentTypeDropdown.Visible = true;
                currentTermsLabel.Visible = true;
                currentTextbox.Visible = true;
                currentColumnFilter.Visible = true;
                currentClear.Visible = true;
                currentFilter = true;
            }
            else
            {
                currentInventoryView.Location = new Point(3, 43);
                currentTypeLabel.Visible = false;
                currentTypeDropdown.Visible = false;
                currentTermsLabel.Visible = false;
                currentTextbox.Visible = false;
                currentColumnFilter.Visible = false;
                currentClear.Visible = false;
                currentFilter = false;
            }
        }

        private void currentClear_Click(object sender, EventArgs e)
        {
            currentTypeDropdown.Text = "";
            currentTextbox.Text = "";
            currentColumnFilter.Text = "";
            currentColumnFilter.Enabled = false;
            CurrentList = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            refreshView(currentInventoryView, CurrentList);
        }

        private void currentTextbox_TextChanged(object sender, EventArgs e)
        {
            if (currentTextbox.Text != "")
            {
                currentColumnFilter.Enabled = true;
            }
            else
            {
                currentColumnFilter.Enabled = false;
            }
        }

        private void currentColumnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MasterInventory> query = new List<MasterInventory>();
            foreach (var x in context.MasterInventories)
            {
                if (x.GetType().GetProperty(currentColumnFilter.Text).GetValue(x).ToString().ToLower().Contains(currentTextbox.Text.ToLower()) && x.UnitsOnHand > 0)
                {
                    query.Add(x);
                }
            }

            CurrentList = query;
            refreshView(currentInventoryView, CurrentList);
        }

        private void currentTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentList = context.MasterInventories
                .Where(x => x.ItemType == currentTypeDropdown.Text && x.UnitsOnHand > 0).ToList();
            refreshView(currentInventoryView, CurrentList);
        }

        private void currentEditButton_Click(object sender, EventArgs e)
        {
            var editPopup = new AddInventory();
            editPopup.Text = "Edit Item";
            editPopup.prepareEdit(CurrentList[RowIndex].Id);
            editPopup.ShowDialog();
            context = new DataContext.DataContext();
            refreshAll();
        }

        #endregion

        #region Inventory History
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
        #endregion 

        #region Menu Strip Buttons
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = new AddInventory();
            popup.ShowDialog();
            refreshAll();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pref = new UserPreferences();
            pref.ShowDialog();
        }
        #endregion

        #region Helper Methods
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

        public void refreshAll()
        {
            CurrentList = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            MasterList = context.MasterInventories.ToList();
            InventoryHistory = context.InventoryHistory.Where(x => x.Updated_TS < DateTime.Now).ToList();
            refreshView(currentInventoryView, CurrentList);
            refreshView(masterListView, MasterList);
            refreshHistory(inventoryHistoryDataGridView, InventoryHistory);
        }

        public void addHistory(int id, int previousUnits)
        {
            var data = context.MasterInventories.Where(x => x.Id == id).ToList();
            context.InventoryHistory.Add(new InventoryHistory()
            {
                ItemId = data[0].Id,
                ItemName = data[0].ItemName,
                CurrentPrice = data[0].UnitPrice,
                PreviousUnitsOnHand = previousUnits,
                NewUnitsOnHand = data[0].UnitsOnHand,
                Updated_TS = DateTime.Now
            });
            context.SaveChanges();
            refreshHistory(inventoryHistoryDataGridView, context.InventoryHistory.Where(x => x.Updated_TS < DateTime.Now).ToList());
        }

        private void setupColors()
        {
            for (int i = 0; i < currentInventoryView.Rows.Count; i++)
            {
                var cell = currentInventoryView.Rows[i].Cells[5];
                if ((int)cell.Value <= 5)
                {
                    cell.Style.ForeColor = Color.Red;
                    cell.Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                }
            }
        }

        private void setupGrid()
        {

            //get user preferences
            var preferences = context.Preferences.FirstOrDefault(x => x.isDefault);
            //currentInventory
            currentInventoryView.DataSource = setupFilters(preferences.CurrentColumnOne);

            currentInventoryView.Columns[4].Visible = false;
            currentInventoryView.Columns[11].Visible = false;
            currentInventoryView.Columns[12].Visible = false;

            int i = 0;

            foreach (DataGridViewColumn c in currentInventoryView.Columns)

            {
                if (c.Visible)
                    i += c.Width;
            }

            currentInventoryView.Width = i + currentInventoryView.RowHeadersWidth + 2;

            if (preferences.NumCurrentGrids > 0)
            {
                currentInventoryGrid2.Visible = true;
                currentInventoryGrid2.DataSource = setupFilters(preferences.CurrentColumnTwo);
                currentInventoryGrid2.Location = new Point(currentInventoryView.Width + 8, 43);

                currentInventoryGrid2.Columns[4].Visible = false;
                currentInventoryGrid2.Columns[11].Visible = false;
                currentInventoryGrid2.Columns[12].Visible = false;

                i = 0;

                foreach (DataGridViewColumn c in currentInventoryGrid2.Columns)

                {
                    if (c.Visible)
                        i += c.Width;
                }

                currentInventoryGrid2.Width = i + currentInventoryGrid2.RowHeadersWidth + 2;
            }

            if (preferences.NumCurrentGrids > 1)
            {
                currentInventoryGrid3.Visible = true;
                currentInventoryGrid3.DataSource = setupFilters(preferences.CurrentColumnThree); 
                currentInventoryGrid3.Location = new Point(currentInventoryView.Width/2, currentInventoryView.Height + 50);

                currentInventoryGrid3.Columns[4].Visible = false;
                currentInventoryGrid3.Columns[11].Visible = false;
                currentInventoryGrid3.Columns[12].Visible = false;

                i = 0;

                foreach (DataGridViewColumn c in currentInventoryGrid3.Columns)

                {
                    if (c.Visible)
                        i += c.Width;
                }

                currentInventoryGrid3.Width = i + currentInventoryGrid3.RowHeadersWidth + 2;

                if (currentInventoryView.Width >= currentInventoryGrid3.Width)
                {
                    currentInventoryGrid3.Width = currentInventoryView.Width;
                }
                else
                {
                    currentInventoryView.Width = currentInventoryGrid3.Width;
                }
            }

            if (preferences.NumCurrentGrids > 2)
            {
                currentInventoryGrid4.Visible = true;
                currentInventoryGrid4.DataSource = setupFilters(preferences.CurrentColumnFour);
                currentInventoryGrid4.Location = new Point(currentInventoryView.Width + 8, currentInventoryView.Height + 50);
                currentInventoryGrid3.Location = new Point(4, currentInventoryView.Height + 50);

                currentInventoryGrid4.Columns[4].Visible = false;
                currentInventoryGrid4.Columns[11].Visible = false;
                currentInventoryGrid4.Columns[12].Visible = false;

                i = 0;

                foreach (DataGridViewColumn c in currentInventoryGrid4.Columns)

                {
                    if (c.Visible)
                        i += c.Width;
                }

                currentInventoryGrid4.Width = i + currentInventoryGrid4.RowHeadersWidth + 2;

                if (currentInventoryGrid2.Width >= currentInventoryGrid4.Width)
                {
                    currentInventoryGrid4.Width = currentInventoryGrid2.Width;
                }
                else
                {
                    currentInventoryGrid2.Width = currentInventoryGrid4.Width;
                }
            }

            if (preferences.NumCurrentGrids == 1)
            {
                Application.OpenForms[0].Size = new System.Drawing.Size(currentInventoryView.Width + currentInventoryGrid2.Width + 40, 800);
            }else if (preferences.NumCurrentGrids > 1)
            {
                Application.OpenForms[0].Size = new System.Drawing.Size(currentInventoryView.Width + currentInventoryGrid2.Width + 40, currentInventoryView.Height * 2 + 200);
            }
        }

        private List<MasterInventory> setupFilters(string filter)
        {
            var newContext = new List<MasterInventory>();
            string caseSwitch = filter;
                switch (caseSwitch)
                {
                    case "All":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
                        break;
                    case "Frozen, Cooler":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 &&(x.ItemType == "Frozen" || x.ItemType == "Cooler" )).ToList();
                        break;
                    case "Frozen, Dry":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 && (x.ItemType == "Frozen" || x.ItemType == "Dry Goods")).ToList();
                        break;
                    case "Cooler, Dry":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 && (x.ItemType == "Dry Goods" || x.ItemType == "Cooler")).ToList();
                        break;
                    case "Frozen":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 && x.ItemType == "Frozen").ToList();
                        break;
                    case "Cooler":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 && x.ItemType == "Cooler").ToList();
                        break;
                    case "Dry":
                        newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 && x.ItemType == "Dry Goods").ToList();
                        break;
                }

            return newContext;
        }

        #endregion

        #region Price Reconciliation 
        private void generateButton_Click(object sender, EventArgs e)
        {
            //clear the text box
            reportTextBox.Text = string.Empty;

            //get the dates and set them to midnight
            var endDate = endDatePicker.Value.Date.AddDays(1);
            var startdate = startDatePicker.Value.Date;

            //get the inventory history for reconciliation
            List<InventoryHistory> dataToReconcile = context.InventoryHistory
                .Where(x => x.Updated_TS >= startdate && x.Updated_TS < endDate).ToList()
                .OrderBy(x => x.Updated_TS.Date).ThenBy(x => x.ItemId).ToList();

            //date, (itemId, itemName, runningAmount, unitPrice, Total)
            Dictionary<DateTime, List<ReconciliationModel>> reconciliationModelsByDate = new Dictionary<DateTime, List<ReconciliationModel>>();

            for (DateTime date = startdate; date < endDate; date = date.AddDays(1))
            {
                reconciliationModelsByDate.Add(date, dataToReconcile
                    .FindAll(x => x.Updated_TS.Date == date)
                    .GroupBy(z => z.ItemId)
                    .Select(y =>
                        new ReconciliationModel
                        {
                            ItemId = y.First().ItemId,
                            ItemName = y.First().ItemName,
                            RunningAmount = y.Sum(s => s.NewUnitsOnHand - s.PreviousUnitsOnHand),
                            UnitPrice = y.First().CurrentPrice,
                            Total = y.Sum(c => c.CurrentPrice * (c.NewUnitsOnHand - c.PreviousUnitsOnHand))
                        })
                    .ToList<ReconciliationModel>());
            }

            writeReconciliationInfoToReportTextBox(reconciliationModelsByDate);
        }

        public void writeReconciliationInfoToReportTextBox(Dictionary<DateTime, List<ReconciliationModel>> reconciliationModelsByDate)
        {
            foreach (var z in reconciliationModelsByDate)
            {
                reportTextBox.SelectionFont = new Font("Arial", 16, FontStyle.Underline);
                reportTextBox.AppendText(z.Key.DayOfWeek + ", " + z.Key.ToShortDateString() + "\n");
                if (z.Value.Count == 0) reportTextBox.AppendText("No change in inventory.\n");
                foreach (ReconciliationModel w in reconciliationModelsByDate[z.Key])
                {
                    reportTextBox.AppendText(w.ItemName + "\t" + w.RunningAmount + " @ " + w.UnitPrice + " = $" + w.Total + "\n");
                }
                reportTextBox.AppendText("\n");
            }
        }


        #endregion

    }
}
