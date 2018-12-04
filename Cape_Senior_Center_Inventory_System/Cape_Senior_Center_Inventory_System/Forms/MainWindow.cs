using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Printing;
using System.IO;
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
        public int masterEditId = 0;
        public int RowIndex;
        public bool masterFilter = false;
        public bool currentFilter = false;
        public bool currentInlineEdit = false;
        public List<string> typeFilterIndex;
        public string chosenPreferenceFilter = "";
      //  public string[] columnNames;
        public int GridWidth = 1000;

        //PRINT SETUP
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;


        //END PRINT SETUP

        public bool showDateRangeFilter = false;
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

            setupGridForCurrentInventory();
            setupGridForMasterInventory();
            setupColors();
            //Application.OpenForms[0].Size = new System.Drawing.Size(masterInventoryView.Width + masterInventoryGrid2.Width + 80, masterInventoryView.Height * 2 + 270);
            var typeFilters = context.ItemType.Select(x => x.Description).ToArray();
            masterTypeDropdownTableOne.Items.AddRange(typeFilters);
            //masterTypeDropdownTableTwo.Items.AddRange(typeFilters);
            //masterTypeDropdownTableThree.Items.AddRange(typeFilters);
            //masterTypeDropdownTableFour.Items.AddRange(typeFilters);

            currentTypeDropdownTableOne.Items.AddRange(typeFilters);
            currentTypeDropdownTableTwo.Items.AddRange(typeFilters);
            currentTypeDropdownTableThree.Items.AddRange(typeFilters);
            currentTypeDropdownTableFour.Items.AddRange(typeFilters);


            var columnNames = typeof(MasterInventory).GetProperties()
                .Select(property => property.Name)
                .ToArray();
            masterColumnFilterTableOne.Items.AddRange(columnNames);
            //masterColumnFilterTableTwo.Items.AddRange(columnNames);
            //masterColumnFilterTableThree.Items.AddRange(columnNames);
            //masterColumnFilterTableFour.Items.AddRange(columnNames);

            currentColumnFilterTableOne.Items.AddRange(columnNames);
            currentColumnFilterTableTwo.Items.AddRange(columnNames);
            currentColumnFilterTableThree.Items.AddRange(columnNames);
            currentColumnFilterTableFour.Items.AddRange(columnNames);
        }

        #region Single Cell Edits

        private void masterListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        //private void firstMasterListView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    masterEditId = (int)masterInventoryView.Rows[e.RowIndex].Cells[0].Value;
        //}

        //private void secondMasterListView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    masterEditId = (int)masterInventoryGrid2.Rows[e.RowIndex].Cells[0].Value;
        //}

        //private void thirdMasterListView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    masterEditId = (int)masterInventoryGrid3.Rows[e.RowIndex].Cells[0].Value;
        //}

        //private void fourthMasterListView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    masterEditId = (int)masterInventoryGrid4.Rows[e.RowIndex].Cells[0].Value;
        //}

        private void DataGridView2_MasterInventory_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editId = (int)masterInventoryView.Rows[RowIndex].Cells[0].Value;
            previousUnits = (int)masterInventoryView.Rows[RowIndex].Cells[5].Value;
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
            var data = masterInventoryView.Rows[RowIndex].Cells[e.ColumnIndex].Value.ToString();
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
            refreshView(masterInventoryView, context.MasterInventories.ToList());
        }
        #endregion

        #region Master Inventory
        private void addRow_Click(object sender, EventArgs e)
        {
            var popup = new AddInventory();
            popup.ShowDialog();

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
            int xDown = 3;
            int yDown = 30;

            if (!masterFilter)
            {
                masterFilter = true;

                masterTypeLabelTableOne.Location = new Point(masterInventoryView.Location.X + xDown, masterInventoryView.Location.Y);
                masterTypeDropdownTableOne.Location = new Point(masterTypeLabelTableOne.Location.X + masterTypeLabelTableOne.Width + xDown, masterInventoryView.Location.Y);
                masterTermsLabelTableOne.Location = new Point(masterTypeDropdownTableOne.Location.X + masterTypeDropdownTableOne.Width + xDown, masterInventoryView.Location.Y);
                masterTextboxTableOne.Location = new Point(masterTermsLabelTableOne.Location.X + masterTermsLabelTableOne.Width + xDown, masterInventoryView.Location.Y);
                masterColumnFilterTableOne.Location = new Point(masterTextboxTableOne.Location.X + masterTextboxTableOne.Width + xDown, masterInventoryView.Location.Y);
                masterClear.Location = new Point(masterColumnFilterTableOne.Location.X + masterColumnFilterTableOne.Width + xDown, masterInventoryView.Location.Y);
                masterInventoryView.Location = new Point(masterInventoryView.Location.X + xDown, masterInventoryView.Location.Y + yDown);



                masterTypeLabelTableOne.Visible = true;
                masterTypeDropdownTableOne.Visible = true;
                masterTermsLabelTableOne.Visible = true;
                masterTextboxTableOne.Visible = true;
                masterColumnFilterTableOne.Visible = true;
                masterClear.Visible = true;

                //if (masterInventoryGrid2.Visible == true)
                //{
                //    masterTypeLabelTableTwo.Location = new Point(masterInventoryGrid2.Location.X + xDown, masterInventoryGrid2.Location.Y);
                //    masterTypeDropdownTableTwo.Location = new Point(masterTypeLabelTableTwo.Location.X + masterTypeLabelTableTwo.Width + xDown, masterInventoryGrid2.Location.Y);
                //    masterTermsLabelTableTwo.Location = new Point(masterTypeDropdownTableTwo.Location.X + masterTypeDropdownTableTwo.Width + xDown, masterInventoryGrid2.Location.Y);
                //    masterTextboxTableTwo.Location = new Point(masterTermsLabelTableTwo.Location.X + masterTermsLabelTableTwo.Width + xDown, masterInventoryGrid2.Location.Y);
                //    masterColumnFilterTableTwo.Location = new Point(masterTextboxTableTwo.Location.X + masterTextboxTableTwo.Width + xDown, masterInventoryGrid2.Location.Y);
                //    masterClearTwo.Location = new Point(masterColumnFilterTableTwo.Location.X + masterColumnFilterTableTwo.Width + xDown, masterInventoryGrid2.Location.Y);
                //    masterInventoryGrid2.Location = new Point(masterInventoryGrid2.Location.X + xDown, masterInventoryGrid2.Location.Y + yDown);


                //    masterTypeLabelTableTwo.Visible = true;
                //    masterTypeDropdownTableTwo.Visible = true;
                //    masterTermsLabelTableTwo.Visible = true;
                //    masterTextboxTableTwo.Visible = true;
                //    masterColumnFilterTableTwo.Visible = true;
                //    masterClearTwo.Visible = true;
                //}

                //if (masterInventoryGrid3.Visible == true)
                //{
                //    masterInventoryGrid3.Location = new Point(masterInventoryGrid3.Location.X + xDown, masterInventoryView.Location.Y + masterInventoryView.Height + yDown);

                //    masterTypeLabelTableThree.Location = new Point(masterInventoryGrid3.Location.X + xDown, masterInventoryGrid3.Location.Y);
                //    masterTypeDropdownTableThree.Location = new Point(masterTypeLabelTableThree.Location.X + masterTypeLabelTableThree.Width + xDown, masterInventoryGrid3.Location.Y);
                //    masterTermsLabelTableThree.Location = new Point(masterTypeDropdownTableThree.Location.X + masterTypeDropdownTableThree.Width + xDown, masterInventoryGrid3.Location.Y);
                //    masterTextboxTableThree.Location = new Point(masterTermsLabelTableThree.Location.X + masterTermsLabelTableThree.Width + xDown, masterInventoryGrid3.Location.Y);
                //    masterColumnFilterTableThree.Location = new Point(masterTextboxTableThree.Location.X + masterTextboxTableThree.Width + xDown, masterInventoryGrid3.Location.Y);
                //    masterClearThree.Location = new Point(masterColumnFilterTableThree.Location.X + masterColumnFilterTableThree.Width + xDown, masterInventoryGrid3.Location.Y);


                //    masterInventoryGrid3.Location = new Point(masterInventoryGrid3.Location.X + xDown, masterInventoryView.Location.Y + masterInventoryView.Height + yDown * 2);

                //    masterTypeLabelTableThree.Visible = true;
                //    masterTypeDropdownTableThree.Visible = true;
                //    masterTermsLabelTableThree.Visible = true;
                //    masterTextboxTableThree.Visible = true;
                //    masterColumnFilterTableThree.Visible = true;
                //    masterClearThree.Visible = true;
                //}

                //if (masterInventoryGrid4.Visible == true)
                //{
                //    masterInventoryGrid4.Location = new Point(masterInventoryGrid2.Location.X + xDown, masterInventoryGrid2.Location.Y + masterInventoryGrid2.Height + yDown);

                //    masterTypeLabelTableFour.Location = new Point(masterInventoryGrid4.Location.X + xDown, masterInventoryGrid4.Location.Y);
                //    masterTypeDropdownTableFour.Location = new Point(masterTypeLabelTableFour.Location.X + masterTypeLabelTableFour.Width + xDown, masterInventoryGrid4.Location.Y);
                //    masterTermsLabelTableFour.Location = new Point(masterTypeDropdownTableFour.Location.X + masterTypeDropdownTableFour.Width + xDown, masterInventoryGrid4.Location.Y);
                //    masterTextboxTableFour.Location = new Point(masterTermsLabelTableFour.Location.X + masterTermsLabelTableFour.Width + xDown, masterInventoryGrid4.Location.Y);
                //    masterColumnFilterTableFour.Location = new Point(masterTextboxTableFour.Location.X + masterTextboxTableFour.Width + xDown, masterInventoryGrid4.Location.Y);
                //    masterClearFour.Location = new Point(masterColumnFilterTableFour.Location.X + masterColumnFilterTableFour.Width + xDown, masterInventoryGrid4.Location.Y);

                //    masterInventoryGrid4.Location = new Point(masterInventoryGrid2.Location.X + xDown, masterInventoryGrid2.Location.Y + masterInventoryGrid2.Height + yDown * 2);

                //    masterTypeLabelTableFour.Visible = true;
                //    masterTypeDropdownTableFour.Visible = true;
                //    masterTermsLabelTableFour.Visible = true;
                //    masterTextboxTableFour.Visible = true;
                //    masterColumnFilterTableFour.Visible = true;
                //    masterClearFour.Visible = true;
                //}

            }
            else
            {

                masterTypeLabelTableOne.Visible = false;
                masterTypeDropdownTableOne.Visible = false;
                masterTermsLabelTableOne.Visible = false;
                masterTextboxTableOne.Visible = false;
                masterColumnFilterTableOne.Visible = false;
                masterClear.Visible = false;
                masterFilter = false;


                //masterTypeLabelTableTwo.Visible = false;
                //masterTypeDropdownTableTwo.Visible = false;
                //masterTermsLabelTableTwo.Visible = false;
                //masterTextboxTableTwo.Visible = false;
                //masterColumnFilterTableTwo.Visible = false;
                //masterClearTwo.Visible = false;
                //masterFilter = false;

                //masterTypeLabelTableThree.Visible = false;
                //masterTypeDropdownTableThree.Visible = false;
                //masterTermsLabelTableThree.Visible = false;
                //masterTextboxTableThree.Visible = false;
                //masterColumnFilterTableThree.Visible = false;
                //masterClearThree.Visible = false;
                //masterFilter = false;

                //masterTypeLabelTableFour.Visible = false;
                //masterTypeDropdownTableFour.Visible = false;
                //masterTermsLabelTableFour.Visible = false;
                //masterTextboxTableFour.Visible = false;
                //masterColumnFilterTableFour.Visible = false;
                //masterClearFour.Visible = false;
                //masterFilter = false;

                masterInventoryView.Location = new Point(3, 43);

                //masterInventoryGrid2.Location = new Point(masterInventoryView.Location.X + masterInventoryView.Width + 10, 43);


                //if (masterInventoryGrid4.Visible == false)
                //{
                //    masterInventoryGrid3.Location = new Point((int)(masterInventoryGrid2.Location.X / 2), masterInventoryGrid3.Height + yDown * 2);

                //}
                //else
                //{
                //    masterInventoryGrid3.Location = new Point(masterInventoryView.Location.X, masterInventoryView.Height + yDown * 2);
                //}

                //masterInventoryGrid4.Location = new Point(masterInventoryView.Location.X + masterInventoryView.Width + 10, masterInventoryView.Height + yDown * 2);
            }
        }

        private void typeFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MasterList = context.MasterInventories.Where(x => x.ItemType == masterTypeDropdownTableOne.Text).ToList();
            refreshView(masterInventoryView, MasterList);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            masterTypeDropdownTableOne.Text = "";
            masterTextboxTableOne.Text = "";
            masterColumnFilterTableOne.Text = "";
            masterColumnFilterTableOne.Enabled = false;
            MasterList = context.MasterInventories.ToList();
            refreshView(masterInventoryView, MasterList);
        }

        private void columnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MasterInventory> query = new List<MasterInventory>();
            foreach (var x in context.MasterInventories)
            {
                if (x.GetType().GetProperty(masterColumnFilterTableOne.Text).GetValue(x).ToString().ToLower().Contains(masterTextboxTableOne.Text.ToLower()))
                {
                    query.Add(x);
                }
            }

            MasterList = query;
            refreshView(masterInventoryView, MasterList);
        }

        private void termsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (masterTextboxTableOne.Text != "")
            {
                masterColumnFilterTableOne.Enabled = true;
            }
            else
            {
                masterColumnFilterTableOne.Enabled = false;
            }
        }
        #endregion

        #region Current Inventory
        private void currentFilterButton_Click(object sender, EventArgs e)
        {
            int xDown = 3;
            int yDown = 30;

            if (!currentFilter)
            {
                currentFilter = true;

                currentTypeLabelTableOne.Location = new Point(currentInventoryView.Location.X + xDown, currentInventoryView.Location.Y);
                currentTypeDropdownTableOne.Location = new Point(currentTypeLabelTableOne.Location.X + currentTypeLabelTableOne.Width + xDown, currentInventoryView.Location.Y);
                currentTermsLabelTableOne.Location = new Point(currentTypeDropdownTableOne.Location.X + currentTypeDropdownTableOne.Width + xDown, currentInventoryView.Location.Y);
                currentTextboxTableOne.Location = new Point(currentTermsLabelTableOne.Location.X + currentTermsLabelTableOne.Width + xDown, currentInventoryView.Location.Y);
                currentColumnFilterTableOne.Location = new Point(currentTextboxTableOne.Location.X + currentTextboxTableOne.Width + xDown, currentInventoryView.Location.Y);
                currentClear.Location = new Point(currentColumnFilterTableOne.Location.X + currentColumnFilterTableOne.Width + xDown, currentInventoryView.Location.Y);
                currentInventoryView.Location = new Point(currentInventoryView.Location.X + xDown, currentInventoryView.Location.Y + yDown);



                currentTypeLabelTableOne.Visible = true;
                currentTypeDropdownTableOne.Visible = true;
                currentTermsLabelTableOne.Visible = true;
                currentTextboxTableOne.Visible = true;
                currentColumnFilterTableOne.Visible = true;
                currentClear.Visible = true;

                if (currentInventoryGrid2.Visible == true)
                {
                    currentTypeLabelTableTwo.Location = new Point(currentInventoryGrid2.Location.X + xDown, currentInventoryGrid2.Location.Y);
                    currentTypeDropdownTableTwo.Location = new Point(currentTypeLabelTableTwo.Location.X + currentTypeLabelTableTwo.Width + xDown, currentInventoryGrid2.Location.Y);
                    currentTermsLabelTableTwo.Location = new Point(currentTypeDropdownTableTwo.Location.X + currentTypeDropdownTableTwo.Width + xDown, currentInventoryGrid2.Location.Y);
                    currentTextboxTableTwo.Location = new Point(currentTermsLabelTableTwo.Location.X + currentTermsLabelTableTwo.Width + xDown, currentInventoryGrid2.Location.Y);
                    currentColumnFilterTableTwo.Location = new Point(currentTextboxTableTwo.Location.X + currentTextboxTableTwo.Width + xDown, currentInventoryGrid2.Location.Y);
                    currentClearTwo.Location = new Point(currentColumnFilterTableTwo.Location.X + currentColumnFilterTableTwo.Width + xDown, currentInventoryGrid2.Location.Y);
                    currentInventoryGrid2.Location = new Point(currentInventoryGrid2.Location.X + xDown, currentInventoryGrid2.Location.Y + yDown);


                    currentTypeLabelTableTwo.Visible = true;
                    currentTypeDropdownTableTwo.Visible = true;
                    currentTermsLabelTableTwo.Visible = true;
                    currentTextboxTableTwo.Visible = true;
                    currentColumnFilterTableTwo.Visible = true;
                    currentClearTwo.Visible = true;
                }

                if (currentInventoryGrid3.Visible == true)
                {
                    currentInventoryGrid3.Location = new Point(currentInventoryGrid3.Location.X + xDown, currentInventoryView.Location.Y + currentInventoryView.Height + yDown);

                    currentTypeLabelTableThree.Location = new Point(currentInventoryGrid3.Location.X + xDown, currentInventoryGrid3.Location.Y);
                    currentTypeDropdownTableThree.Location = new Point(currentTypeLabelTableThree.Location.X + currentTypeLabelTableThree.Width + xDown, currentInventoryGrid3.Location.Y);
                    currentTermsLabelTableThree.Location = new Point(currentTypeDropdownTableThree.Location.X + currentTypeDropdownTableThree.Width + xDown, currentInventoryGrid3.Location.Y);
                    currentTextboxTableThree.Location = new Point(currentTermsLabelTableThree.Location.X + currentTermsLabelTableThree.Width + xDown, currentInventoryGrid3.Location.Y);
                    currentColumnFilterTableThree.Location = new Point(currentTextboxTableThree.Location.X + currentTextboxTableThree.Width + xDown, currentInventoryGrid3.Location.Y);
                    currentClearThree.Location = new Point(currentColumnFilterTableThree.Location.X + currentColumnFilterTableThree.Width + xDown, currentInventoryGrid3.Location.Y);


                    currentInventoryGrid3.Location = new Point(currentInventoryGrid3.Location.X + xDown, currentInventoryView.Location.Y + currentInventoryView.Height + yDown * 2);

                    currentTypeLabelTableThree.Visible = true;
                    currentTypeDropdownTableThree.Visible = true;
                    currentTermsLabelTableThree.Visible = true;
                    currentTextboxTableThree.Visible = true;
                    currentColumnFilterTableThree.Visible = true;
                    currentClearThree.Visible = true;
                }

                if (currentInventoryGrid4.Visible == true)
                {
                    currentInventoryGrid4.Location = new Point(currentInventoryGrid2.Location.X + xDown, currentInventoryGrid2.Location.Y + currentInventoryGrid2.Height + yDown);

                    currentTypeLabelTableFour.Location = new Point(currentInventoryGrid4.Location.X + xDown, currentInventoryGrid4.Location.Y);
                    currentTypeDropdownTableFour.Location = new Point(currentTypeLabelTableFour.Location.X + currentTypeLabelTableFour.Width + xDown, currentInventoryGrid4.Location.Y);
                    currentTermsLabelTableFour.Location = new Point(currentTypeDropdownTableFour.Location.X + currentTypeDropdownTableFour.Width + xDown, currentInventoryGrid4.Location.Y);
                    currentTextboxTableFour.Location = new Point(currentTermsLabelTableFour.Location.X + currentTermsLabelTableFour.Width + xDown, currentInventoryGrid4.Location.Y);
                    currentColumnFilterTableFour.Location = new Point(currentTextboxTableFour.Location.X + currentTextboxTableFour.Width + xDown, currentInventoryGrid4.Location.Y);
                    currentClearFour.Location = new Point(currentColumnFilterTableFour.Location.X + currentColumnFilterTableFour.Width + xDown, currentInventoryGrid4.Location.Y);

                    currentInventoryGrid4.Location = new Point(currentInventoryGrid2.Location.X + xDown, currentInventoryGrid2.Location.Y + currentInventoryGrid2.Height + yDown * 2);

                    currentTypeLabelTableFour.Visible = true;
                    currentTypeDropdownTableFour.Visible = true;
                    currentTermsLabelTableFour.Visible = true;
                    currentTextboxTableFour.Visible = true;
                    currentColumnFilterTableFour.Visible = true;
                    currentClearFour.Visible = true;
                }

            }
            else
            {

                currentTypeLabelTableOne.Visible = false;
                currentTypeDropdownTableOne.Visible = false;
                currentTermsLabelTableOne.Visible = false;
                currentTextboxTableOne.Visible = false;
                currentColumnFilterTableOne.Visible = false;
                currentClear.Visible = false;
                currentFilter = false;


                currentTypeLabelTableTwo.Visible = false;
                currentTypeDropdownTableTwo.Visible = false;
                currentTermsLabelTableTwo.Visible = false;
                currentTextboxTableTwo.Visible = false;
                currentColumnFilterTableTwo.Visible = false;
                currentClearTwo.Visible = false;
                currentFilter = false;

                currentTypeLabelTableThree.Visible = false;
                currentTypeDropdownTableThree.Visible = false;
                currentTermsLabelTableThree.Visible = false;
                currentTextboxTableThree.Visible = false;
                currentColumnFilterTableThree.Visible = false;
                currentClearThree.Visible = false;
                currentFilter = false;

                currentTypeLabelTableFour.Visible = false;
                currentTypeDropdownTableFour.Visible = false;
                currentTermsLabelTableFour.Visible = false;
                currentTextboxTableFour.Visible = false;
                currentColumnFilterTableFour.Visible = false;
                currentClearFour.Visible = false;
                currentFilter = false;

                currentInventoryView.Location = new Point(3, 43);

                currentInventoryGrid2.Location = new Point(currentInventoryView.Location.X + currentInventoryView.Width + 10, 43);

                if (currentInventoryGrid4.Visible == false)
                {
                    currentInventoryGrid3.Location = new Point((int)(currentInventoryGrid2.Location.X/2), currentInventoryGrid3.Height + yDown * 2);
                 
                }
                else
                {
                    currentInventoryGrid3.Location = new Point(currentInventoryView.Location.X, currentInventoryView.Height + yDown * 2);
                }



                currentInventoryGrid4.Location = new Point(currentInventoryView.Location.X + currentInventoryView.Width + 10, currentInventoryView.Height + yDown * 2);
            }
        }

        private void currentClear_Click(object sender, EventArgs e)
        {
            currentTypeDropdownTableOne.Text = "";
            currentTextboxTableOne.Text = "";
            currentColumnFilterTableOne.Text = "";
            currentColumnFilterTableOne.Enabled = false;
            CurrentList = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
            refreshView(currentInventoryView, CurrentList);
        }

        private void currentTextbox_TextChanged(object sender, EventArgs e)
        {
            if (currentTextboxTableOne.Text != "")
            {
                currentColumnFilterTableOne.Enabled = true;
            }
            else
            {
                currentColumnFilterTableOne.Enabled = false;
            }
        }

        private void currentColumnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MasterInventory> query = new List<MasterInventory>();
            foreach (var x in context.MasterInventories)
            {
                if (x.GetType().GetProperty(currentColumnFilterTableOne.Text).GetValue(x).ToString().ToLower().Contains(currentTextboxTableOne.Text.ToLower()) && x.UnitsOnHand > 0)
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
                .Where(x => x.ItemType == currentTypeDropdownTableOne.Text && x.UnitsOnHand > 0).ToList();
            refreshView(currentInventoryView, CurrentList);
        }

        //private void currentEditButton_Click(object sender, EventArgs e)
        //{
        //    var editPopup = new AddInventory();
        //    editPopup.Text = "Edit Item";
        //    editPopup.prepareEdit(CurrentList[RowIndex].Id);
        //    editPopup.ShowDialog();
        //    context = new DataContext.DataContext();
        //    refreshAll();
        //}

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
            var pref = new UserPreferences(this);
            pref.ShowDialog();

            if (masterFilter)
            {
                filterButton_Click("update", new EventArgs());
            }
            if (currentFilter)
            {
                currentFilterButton_Click("update", new EventArgs());
            }
            setupGridForCurrentInventory();
            setupGridForMasterInventory();
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
            refreshView(masterInventoryView, MasterList);
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
            for (int i = 0; i < masterInventoryView.Rows.Count; i++)
            {
                var cell = masterInventoryView.Rows[i].Cells[5];
                if ((int)cell.Value <= 5)
                {
                    cell.Style.ForeColor = Color.Red;
                    cell.Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                }
            }
        }

        private void setupGridForCurrentInventory()
        {
            DataContext.DataContext context = new DataContext.DataContext();
            //get user preferences

            currentInventoryView.Location = new Point(3, 43);

            currentInventoryGrid2.Visible = false;
            currentInventoryGrid3.Visible = false;
            currentInventoryGrid4.Visible = false;
            Preferences preferences = new Preferences();
            if (string.IsNullOrWhiteSpace(chosenPreferenceFilter))
             {
                 preferences = context.Preferences.FirstOrDefault(x => x.isDefault);
            }
            else
            {
                preferences = context.Preferences.FirstOrDefault(x => x.PreferencesName==chosenPreferenceFilter);
            }
            //currentInventory
            currentInventoryView.DataSource = setupFiltersForCurrentInventory(preferences.CurrentColumnOne);

            currentInventoryView.Columns[4].Visible = false;
            currentInventoryView.Columns[11].Visible = false;
            currentInventoryView.Columns[12].Visible = false;
            currentInventoryView.Width = GridWidth;
            currentInventoryGrid2.Width = GridWidth;
            currentInventoryGrid3.Width = GridWidth;
            currentInventoryGrid4.Width = GridWidth;
            int i = 0;

            //foreach (DataGridViewColumn c in currentInventoryView.Columns)

            //{
            //    if (c.Visible)
            //        i += c.Width;
            //}

          //  currentInventoryView.Width = i + currentInventoryView.RowHeadersWidth + 2;

            if (preferences.NumCurrentGrids > 0)
            {
                currentInventoryGrid2.Visible = true;
                currentInventoryGrid2.DataSource = setupFiltersForCurrentInventory(preferences.CurrentColumnTwo);
                currentInventoryGrid2.Location = new Point(currentInventoryView.Width + 8, 43);

                currentInventoryGrid2.Columns[4].Visible = false;
                currentInventoryGrid2.Columns[11].Visible = false;
                currentInventoryGrid2.Columns[12].Visible = false;

                i = 0;

                //foreach (DataGridViewColumn c in currentInventoryGrid2.Columns)

                //{
                //    if (c.Visible)
                //        i += c.Width;
                //}

                //currentInventoryGrid2.Width = i + currentInventoryGrid2.RowHeadersWidth + 2;
            }

            if (preferences.NumCurrentGrids > 1)
            {
                currentInventoryGrid3.Visible = true;
                currentInventoryGrid3.DataSource = setupFiltersForCurrentInventory(preferences.CurrentColumnThree);
                currentInventoryGrid3.Location = new Point(currentInventoryView.Width / 2, currentInventoryView.Height + 50);

                currentInventoryGrid3.Columns[4].Visible = false;
                currentInventoryGrid3.Columns[11].Visible = false;
                currentInventoryGrid3.Columns[12].Visible = false;

                i = 0;

                //foreach (DataGridViewColumn c in currentInventoryGrid3.Columns)

                //{
                //    if (c.Visible)
                //        i += c.Width;
                //}

                //currentInventoryGrid3.Width = i + currentInventoryGrid3.RowHeadersWidth + 2;

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
                currentInventoryGrid4.DataSource = setupFiltersForCurrentInventory(preferences.CurrentColumnFour);
                currentInventoryGrid4.Location = new Point(currentInventoryView.Width + 8, currentInventoryView.Height + 50);
                currentInventoryGrid3.Location = new Point(4, currentInventoryView.Height + 50);

                currentInventoryGrid4.Columns[4].Visible = false;
                currentInventoryGrid4.Columns[11].Visible = false;
                currentInventoryGrid4.Columns[12].Visible = false;

                i = 0;

                //foreach (DataGridViewColumn c in currentInventoryGrid4.Columns)

                //{
                //    if (c.Visible)
                //        i += c.Width;
                //}

                //currentInventoryGrid4.Width = i + currentInventoryGrid4.RowHeadersWidth + 2;

                if (currentInventoryGrid2.Width >= currentInventoryGrid4.Width)
                {
                    currentInventoryGrid4.Width = currentInventoryGrid2.Width;
                }
                else
                {
                    currentInventoryGrid2.Width = currentInventoryGrid4.Width;
                }
            }

            //if (preferences.NumCurrentGrids == 1)
            //{
            //    Application.OpenForms[0].Size = new System.Drawing.Size(currentInventoryView.Width + currentInventoryGrid2.Width + 40, 800);
            //}
            //else if (preferences.NumCurrentGrids > 1)
            //{
            //    Application.OpenForms[0].Size = new System.Drawing.Size(currentInventoryView.Width + currentInventoryGrid2.Width + 80, currentInventoryView.Height * 2 + 270);
            //}
        }


        private void setupGridForMasterInventory()
        {
            DataContext.DataContext context = new DataContext.DataContext();
            //get user preferences
            //masterInventoryGrid2.Visible = false;
            //masterInventoryGrid3.Visible = false;
            //masterInventoryGrid4.Visible = false;
            Preferences preferences = new Preferences();
            if (string.IsNullOrWhiteSpace(chosenPreferenceFilter))
            {
                preferences = context.Preferences.FirstOrDefault(x => x.isDefault);
            }
            else
            {
                preferences = context.Preferences.FirstOrDefault(x => x.PreferencesName == chosenPreferenceFilter);
            }
            //masterInventory




            masterInventoryView.DataSource = setupFiltersForCurrentInventory(preferences.MasterColumnOne);
            masterInventoryView.Location = new Point(3, 43);
            masterInventoryView.Columns[4].Visible = false;
            masterInventoryView.Columns[11].Visible = false;
            masterInventoryView.Columns[12].Visible = false;
            masterInventoryView.Width = GridWidth;
            //masterInventoryGrid2.Width = GridWidth;
            //masterInventoryGrid3.Width = GridWidth;
            //masterInventoryGrid4.Width = GridWidth;

            int i = 0;

            //foreach (DataGridViewColumn c in masterInventoryView.Columns)

            //{
            //    if (c.Visible)
            //        i += c.Width;
            //}

            //masterInventoryView.Width = i + masterInventoryView.RowHeadersWidth + 2;
            

            if (preferences.NumMasterGrids > 0)
            {
                //masterInventoryGrid2.Visible = true;
                //masterInventoryGrid2.DataSource = setupFiltersForMasterInventory(preferences.MasterColumnTwo);
                //masterInventoryGrid2.Location = new Point(masterInventoryView.Width + 8, 43);

                //masterInventoryGrid2.Columns[4].Visible = false;
                //masterInventoryGrid2.Columns[11].Visible = false;
                //masterInventoryGrid2.Columns[12].Visible = false;

                i = 0;

                //foreach (DataGridViewColumn c in masterInventoryGrid2.Columns)

                //{
                //    if (c.Visible)
                //        i += c.Width;
                //}

                //masterInventoryGrid2.Width = i + masterInventoryGrid2.RowHeadersWidth + 2;
            }

            if (preferences.NumMasterGrids > 1)
            {
                //masterInventoryGrid3.Visible = true;
                //masterInventoryGrid3.DataSource = setupFiltersForMasterInventory(preferences.MasterColumnThree);
                //masterInventoryGrid3.Location = new Point(masterInventoryView.Width / 2, masterInventoryView.Height + 50);

                //masterInventoryGrid3.Columns[4].Visible = false;
                //masterInventoryGrid3.Columns[11].Visible = false;
                //masterInventoryGrid3.Columns[12].Visible = false;

                i = 0;

                //foreach (DataGridViewColumn c in masterInventoryGrid3.Columns)

                //{
                //    if (c.Visible)
                //        i += c.Width;
                //}

                //masterInventoryGrid3.Width = i + masterInventoryGrid3.RowHeadersWidth + 2;

                //if (masterInventoryView.Width >= masterInventoryGrid3.Width)
                //{
                //    masterInventoryGrid3.Width = masterInventoryView.Width;
                //}
                //else
                //{
                //    masterInventoryView.Width = masterInventoryGrid3.Width;
                //}
            }

            if (preferences.NumMasterGrids > 2)
            {
                //masterInventoryGrid4.Visible = true;
                //masterInventoryGrid4.DataSource = setupFiltersForMasterInventory(preferences.MasterColumnFour);
                //masterInventoryGrid4.Location = new Point(masterInventoryView.Width + 8, masterInventoryView.Height + 50);
                //masterInventoryGrid3.Location = new Point(4, masterInventoryView.Height + 50);

                //masterInventoryGrid4.Columns[4].Visible = false;
                //masterInventoryGrid4.Columns[11].Visible = false;
                //masterInventoryGrid4.Columns[12].Visible = false;

                i = 0;

                //foreach (DataGridViewColumn c in masterInventoryGrid4.Columns)

                //{
                //    if (c.Visible)
                //        i += c.Width;
                //}

                //masterInventoryGrid4.Width = i + masterInventoryGrid4.RowHeadersWidth + 2;

                //if (masterInventoryGrid2.Width >= masterInventoryGrid4.Width)
                //{
                //    masterInventoryGrid4.Width = masterInventoryGrid2.Width;
                //}
                //else
                //{
                //    masterInventoryGrid2.Width = masterInventoryGrid4.Width;
                //}
            }

            //if (preferences.NumMasterGrids == 1)
            //{
            //    Application.OpenForms[0].Size = new System.Drawing.Size(masterInventoryView.Width + masterInventoryGrid2.Width + 40, 800);
            //}
            //else if (preferences.NumMasterGrids > 1)
            //{
            //    Application.OpenForms[0].Size = new System.Drawing.Size(masterInventoryView.Width + masterInventoryGrid2.Width + 80, masterInventoryView.Height * 2 + 270);
            //}
        }

        private List<MasterInventory> setupFiltersForCurrentInventory(string filter)
        {
            var newContext = new List<MasterInventory>();
            string caseSwitch = filter;
            switch (caseSwitch)
            {
                case "All":
                    newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0).ToList();
                    break;
                case "Frozen, Cooler":
                    newContext = context.MasterInventories.Where(x => x.UnitsOnHand > 0 && (x.ItemType == "Frozen" || x.ItemType == "Cooler")).ToList();
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

        private List<MasterInventory> setupFiltersForMasterInventory(string filter)
        {
            var newContext = new List<MasterInventory>();
            string caseSwitch = filter;
            switch (caseSwitch)
            {
                case "All":
                    newContext = context.MasterInventories.ToList();
                    break;
                case "Frozen, Cooler":
                    newContext = context.MasterInventories.Where(x => (x.ItemType == "Frozen" || x.ItemType == "Cooler")).ToList();
                    break;
                case "Frozen, Dry":
                    newContext = context.MasterInventories.Where(x =>(x.ItemType == "Frozen" || x.ItemType == "Dry Goods")).ToList();
                    break;
                case "Cooler, Dry":
                    newContext = context.MasterInventories.Where(x => (x.ItemType == "Dry Goods" || x.ItemType == "Cooler")).ToList();
                    break;
                case "Frozen":
                    newContext = context.MasterInventories.Where(x =>  x.ItemType == "Frozen").ToList();
                    break;
                case "Cooler":
                    newContext = context.MasterInventories.Where(x => x.ItemType == "Cooler").ToList();
                    break;
                case "Dry":
                    newContext = context.MasterInventories.Where(x => x.ItemType == "Dry Goods").ToList();
                    break;
            }

            return newContext;
        }

        #endregion

        #region Price Reconciliation 
        private void generateButton_Click(object sender, EventArgs e)
        {
            //clear the data grid view
            reportDataGridView.DataSource = null;
            reportDataGridView.Rows.Clear();
            reportDataGridView.Columns.Clear();
            reportDataGridView.Refresh();

            //get the dates and set them to midnight
            var endDate = endDatePicker.Value.Date.AddDays(1);
            var startdate = startDatePicker.Value.Date;

            List<InventoryHistory> inventoryHistories = context.InventoryHistory.ToList();
            List<Item> items = context.Items.ToList();

            //get the inventory history for reconciliation
            List<InventoryHistoryModel> dataToReconcile = context.InventoryHistory
                .Join(
                    context.MasterInventories,
                    inventoryHistory => inventoryHistory.ItemId,
                    masterInventory => masterInventory.Id,
                    (inventoryHistory, masterInventory) => new InventoryHistoryModel
                    {
                        Id = inventoryHistory.Id,
                        ItemId = inventoryHistory.ItemId,
                        ItemName = masterInventory.ItemName,
                        CurrentPrice = inventoryHistory.CurrentPrice,
                        PreviousUnitsOnHand = inventoryHistory.PreviousUnitsOnHand,
                        Updated_TS = inventoryHistory.Updated_TS
                    }
                )
                .Where(x => x.Updated_TS >= startdate && x.Updated_TS < endDate)
                .OrderBy(x => x.Updated_TS).ThenBy(x => x.ItemId).ToList();

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
                            ItemName = y.Last().ItemName,
                            RunningAmount = y.Sum(s => s.NewUnitsOnHand - s.PreviousUnitsOnHand),
                            UnitPrice = y.First().CurrentPrice,
                            Total = y.Sum(c => c.CurrentPrice * (c.NewUnitsOnHand - c.PreviousUnitsOnHand))
                        })
                    .ToList<ReconciliationModel>());
            }
            writeReconciliationInfoToReportDataGridView(reconciliationModelsByDate);
            ////writeReconciliationInfoToReportTextBox(reconciliationModelsByDate);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var endDate = endDatePicker.Value.Date.AddDays(1);
            var startdate = startDatePicker.Value.Date;

            List<InventoryHistoryModel> dataToReconcile = context.InventoryHistory
                .Join(
                    context.MasterInventories,
                    inventoryHistory => inventoryHistory.ItemId,
                    masterInventory => masterInventory.Id,
                    (inventoryHistory, masterInventory) => new InventoryHistoryModel
                    {
                        Id = inventoryHistory.Id,
                        ItemId = inventoryHistory.ItemId,
                        ItemName = masterInventory.ItemName,
                        CurrentPrice = inventoryHistory.CurrentPrice,
                        PreviousUnitsOnHand = inventoryHistory.PreviousUnitsOnHand,
                        Updated_TS = inventoryHistory.Updated_TS
                    }
                )
                .Where(x => x.Updated_TS >= startdate && x.Updated_TS < endDate).ToList()
                .OrderBy(x => x.Updated_TS.Date).ThenBy(x => x.ItemId).ToList();

            List<BalanceReportItemModel> items = new List<BalanceReportItemModel>();

            double dataTotal = 0;
            double incomingTotal = 0;
            double outgoingTotal = 0;
            double total = 0;

            foreach (InventoryHistoryModel data in dataToReconcile)
            {
                dataTotal = data.CurrentPrice * (data.NewUnitsOnHand - data.PreviousUnitsOnHand);

                if (items.Exists(x => x.ItemId == data.ItemId))
                {
                    items.Find(x => x.ItemId == data.ItemId).Total += dataTotal;
                    items.Find(x => x.ItemId == data.ItemId).Name = data.ItemName;
                }
                else
                {
                    BalanceReportItemModel model = new BalanceReportItemModel
                    {
                        ItemId = data.ItemId,
                        Name = data.ItemName,
                        Total = dataTotal
                    };

                    items.Add(model);
                }

                total += dataTotal;
            }

            items.ForEach(item =>
            {
                if (item.Total < 0)
                {
                    outgoingTotal += item.Total;
                } else
                {
                    incomingTotal += item.Total;
                }
            });

            BalanceReportTotalsModel totals = new BalanceReportTotalsModel
            {
                incomingTotal = incomingTotal,
                outgoingTotal = outgoingTotal,
                total = total
            };

            generatePdfOrSomething(items, totals);
        }

        private void generatePdfOrSomething(List<BalanceReportItemModel> items, BalanceReportTotalsModel totals)
        {
            items.ForEach(item =>
            {
                Console.WriteLine("Item Name: " + item.Name);
                Console.WriteLine("Item Total: " + item.Total);
                Console.WriteLine("");
            });
            Console.WriteLine("Incoming Total: " + totals.incomingTotal);
            Console.WriteLine("Outgoing Total: " + totals.outgoingTotal);
            Console.WriteLine("Total Total: " + totals.total);
        }

        public void writeReconciliationInfoToReportDataGridView(Dictionary<DateTime, List<ReconciliationModel>> reconciliationModelByDate)
        {

            reportDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Item"
            });
            foreach (var day in reconciliationModelByDate)
            {
                reportDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = day.Key.DayOfWeek.ToString() + ' ' + day.Key.ToShortDateString()
                });
                foreach (ReconciliationModel w in reconciliationModelByDate[day.Key])
                {
                    var temp = new
                    {
                        Item = w.ItemName.ToString(),
                        Amount = w.RunningAmount.ToString(),
                        Price = w.UnitPrice.ToString("C"),
                        Total = w.Total.ToString("C")
                    };

                    DataGridViewRow existingRow = reportDataGridView.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r =>
                        {
                            if (r.Cells["Item"].Value == null)
                                return false;
                            return r.Cells["Item"].Value.ToString().Equals(w.ItemName);
                        })
                        .FirstOrDefault();

                    if (existingRow == null)
                    {
                        reportDataGridView.Rows.Add(temp.Item);

                        existingRow = reportDataGridView.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r =>
                        {
                            if (r.Cells["Item"].Value == null)
                                return false;
                            return r.Cells["Item"].Value.ToString().Equals(w.ItemName);
                        })
                        .FirstOrDefault();
                    }

                    existingRow.Cells[day.Key.DayOfWeek.ToString() + ' ' + day.Key.ToShortDateString()].Value = temp.Amount + " x " + temp.Price + " = " + temp.Total;
                }
            }

        }


        #endregion
    }

        private void reportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void masterListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showDateRangeButton_Click(object sender, EventArgs e)
        {
            showDateRangeFilter = !showDateRangeFilter;
            dateRangePanel.Visible = showDateRangeFilter;
            showDateRangeButton.Text = showDateRangeFilter ? "Hide Filter" : "Show Filter";
        }
    }
}
