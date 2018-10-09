using System;
using System.Drawing;

namespace Cape_Senior_Center_Inventory_System
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterInventoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Cape_Senior_Center_Inventory_System.DatabaseDataSet();
            this.masterInventoriesTableAdapter = new Cape_Senior_Center_Inventory_System.DatabaseDataSetTableAdapters.MasterInventoriesTableAdapter();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.inventoryHistoryTab = new System.Windows.Forms.TabPage();
            this.inventoryHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inventoryHistoryEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.inventoryHistoryStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pricingHistoryTab = new System.Windows.Forms.TabPage();
            this.pricingHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pricingHistoryEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pricingHistoryStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.pricingTab = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.pricingReconcileTab = new System.Windows.Forms.TabPage();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.currentTab = new System.Windows.Forms.TabPage();
            this.currentInventoryView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.masterListTab = new System.Windows.Forms.TabPage();
            this.masterListView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addRow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendedPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceUnitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendedPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedTSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMasterInventory = new System.Windows.Forms.BindingSource(this.components);
            this.bsCurrentInventory = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterInventoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.historyTab.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.inventoryHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.pricingHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricingHistoryDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.pricingTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.currentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryView)).BeginInit();
            this.panel1.SuspendLayout();
            this.masterListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterListView)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1260, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // masterInventoriesBindingSource
            // 
            this.masterInventoriesBindingSource.DataMember = "MasterInventories";
            this.masterInventoriesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterInventoriesTableAdapter
            // 
            this.masterInventoriesTableAdapter.ClearBeforeFill = true;
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.tabControl4);
            this.historyTab.Location = new System.Drawing.Point(4, 29);
            this.historyTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(1252, 1024);
            this.historyTab.TabIndex = 8;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.inventoryHistoryTab);
            this.tabControl4.Controls.Add(this.pricingHistoryTab);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1252, 1024);
            this.tabControl4.TabIndex = 0;
            // 
            // inventoryHistoryTab
            // 
            this.inventoryHistoryTab.Controls.Add(this.inventoryHistoryDataGridView);
            this.inventoryHistoryTab.Controls.Add(this.panel4);
            this.inventoryHistoryTab.Location = new System.Drawing.Point(4, 29);
            this.inventoryHistoryTab.Name = "inventoryHistoryTab";
            this.inventoryHistoryTab.Size = new System.Drawing.Size(1244, 991);
            this.inventoryHistoryTab.TabIndex = 2;
            this.inventoryHistoryTab.Text = "Inventory";
            this.inventoryHistoryTab.UseVisualStyleBackColor = true;
            // 
            // inventoryHistoryDataGridView
            // 
            this.inventoryHistoryDataGridView.AllowUserToAddRows = false;
            this.inventoryHistoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.inventoryHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryHistoryDataGridView.Location = new System.Drawing.Point(0, 75);
            this.inventoryHistoryDataGridView.Name = "inventoryHistoryDataGridView";
            this.inventoryHistoryDataGridView.ReadOnly = true;
            this.inventoryHistoryDataGridView.RowTemplate.Height = 24;
            this.inventoryHistoryDataGridView.Size = new System.Drawing.Size(1244, 916);
            this.inventoryHistoryDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Item Type";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "SKU";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Units On Hand";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Inv. Name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Extended Price";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.inventoryHistoryEndDatePicker);
            this.panel4.Controls.Add(this.inventoryHistoryStartDatePicker);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1244, 75);
            this.panel4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(921, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(780, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Start Date";
            // 
            // inventoryHistoryEndDatePicker
            // 
            this.inventoryHistoryEndDatePicker.CustomFormat = "";
            this.inventoryHistoryEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inventoryHistoryEndDatePicker.Location = new System.Drawing.Point(924, 31);
            this.inventoryHistoryEndDatePicker.Name = "inventoryHistoryEndDatePicker";
            this.inventoryHistoryEndDatePicker.Size = new System.Drawing.Size(134, 26);
            this.inventoryHistoryEndDatePicker.TabIndex = 2;
            // 
            // inventoryHistoryStartDatePicker
            // 
            this.inventoryHistoryStartDatePicker.CustomFormat = "";
            this.inventoryHistoryStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inventoryHistoryStartDatePicker.Location = new System.Drawing.Point(783, 31);
            this.inventoryHistoryStartDatePicker.Name = "inventoryHistoryStartDatePicker";
            this.inventoryHistoryStartDatePicker.Size = new System.Drawing.Size(134, 26);
            this.inventoryHistoryStartDatePicker.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Inventory History";
            // 
            // pricingHistoryTab
            // 
            this.pricingHistoryTab.Controls.Add(this.pricingHistoryDataGridView);
            this.pricingHistoryTab.Controls.Add(this.panel5);
            this.pricingHistoryTab.Location = new System.Drawing.Point(4, 29);
            this.pricingHistoryTab.Name = "pricingHistoryTab";
            this.pricingHistoryTab.Size = new System.Drawing.Size(1244, 991);
            this.pricingHistoryTab.TabIndex = 1;
            this.pricingHistoryTab.Text = "Pricing";
            this.pricingHistoryTab.UseVisualStyleBackColor = true;
            // 
            // pricingHistoryDataGridView
            // 
            this.pricingHistoryDataGridView.AllowUserToAddRows = false;
            this.pricingHistoryDataGridView.AllowUserToDeleteRows = false;
            this.pricingHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pricingHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricingHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pricingHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricingHistoryDataGridView.Location = new System.Drawing.Point(0, 75);
            this.pricingHistoryDataGridView.Name = "pricingHistoryDataGridView";
            this.pricingHistoryDataGridView.ReadOnly = true;
            this.pricingHistoryDataGridView.RowTemplate.Height = 24;
            this.pricingHistoryDataGridView.Size = new System.Drawing.Size(1244, 916);
            this.pricingHistoryDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SKU";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Units On Hand";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Inv. Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Extended Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.pricingHistoryEndDatePicker);
            this.panel5.Controls.Add(this.pricingHistoryStartDatePicker);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1244, 75);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(921, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "End Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(780, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Start Date";
            // 
            // pricingHistoryEndDatePicker
            // 
            this.pricingHistoryEndDatePicker.CustomFormat = "";
            this.pricingHistoryEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pricingHistoryEndDatePicker.Location = new System.Drawing.Point(924, 31);
            this.pricingHistoryEndDatePicker.Name = "pricingHistoryEndDatePicker";
            this.pricingHistoryEndDatePicker.Size = new System.Drawing.Size(134, 26);
            this.pricingHistoryEndDatePicker.TabIndex = 2;
            // 
            // pricingHistoryStartDatePicker
            // 
            this.pricingHistoryStartDatePicker.CustomFormat = "";
            this.pricingHistoryStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pricingHistoryStartDatePicker.Location = new System.Drawing.Point(783, 31);
            this.pricingHistoryStartDatePicker.Name = "pricingHistoryStartDatePicker";
            this.pricingHistoryStartDatePicker.Size = new System.Drawing.Size(134, 26);
            this.pricingHistoryStartDatePicker.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(471, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Pricing History";
            // 
            // pricingTab
            // 
            this.pricingTab.Controls.Add(this.tabControl3);
            this.pricingTab.Location = new System.Drawing.Point(4, 29);
            this.pricingTab.Name = "pricingTab";
            this.pricingTab.Size = new System.Drawing.Size(1252, 1024);
            this.pricingTab.TabIndex = 9;
            this.pricingTab.Text = "Pricing";
            this.pricingTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.pricingReconcileTab);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1252, 1024);
            this.tabControl3.TabIndex = 0;
            // 
            // pricingReconcileTab
            // 
            this.pricingReconcileTab.Location = new System.Drawing.Point(4, 29);
            this.pricingReconcileTab.Name = "pricingReconcileTab";
            this.pricingReconcileTab.Padding = new System.Windows.Forms.Padding(3);
            this.pricingReconcileTab.Size = new System.Drawing.Size(1244, 991);
            this.pricingReconcileTab.TabIndex = 0;
            this.pricingReconcileTab.Text = "Reconcile";
            this.pricingReconcileTab.UseVisualStyleBackColor = true;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.tabControl2);
            this.inventoryTab.Location = new System.Drawing.Point(4, 29);
            this.inventoryTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(1252, 1024);
            this.inventoryTab.TabIndex = 6;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.currentTab);
            this.tabControl2.Controls.Add(this.masterListTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1252, 1024);
            this.tabControl2.TabIndex = 0;
            // 
            // currentTab
            // 
            this.currentTab.Controls.Add(this.currentInventoryView);
            this.currentTab.Controls.Add(this.panel1);
            this.currentTab.Location = new System.Drawing.Point(4, 29);
            this.currentTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentTab.Name = "currentTab";
            this.currentTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentTab.Size = new System.Drawing.Size(1244, 991);
            this.currentTab.TabIndex = 0;
            this.currentTab.Text = "Current";
            this.currentTab.UseVisualStyleBackColor = true;
            // 
            // currentInventoryView
            // 
            this.currentInventoryView.AutoGenerateColumns = false;
            this.currentInventoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.currentInventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentInventoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.sKUDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceUnitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.extendedPriceDataGridViewTextBoxColumn,
            this.createdTSDataGridViewTextBoxColumn,
            this.updatedTSDataGridViewTextBoxColumn});
            this.currentInventoryView.DataSource = this.masterInventoriesBindingSource;
            this.currentInventoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentInventoryView.Location = new System.Drawing.Point(4, 67);
            this.currentInventoryView.Name = "currentInventoryView";
            this.currentInventoryView.ReadOnly = true;
            this.currentInventoryView.RowTemplate.Height = 24;
            this.currentInventoryView.Size = new System.Drawing.Size(1236, 919);
            this.currentInventoryView.TabIndex = 4;
            this.currentInventoryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentInventoryView_CellContentClick);
            this.currentInventoryView.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            this.currentInventoryView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CurrentInventory_EndEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 62);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Inventory";
            // 
            // masterListTab
            // 
            this.masterListTab.Controls.Add(this.masterListView);
            this.masterListTab.Controls.Add(this.panel2);
            this.masterListTab.Location = new System.Drawing.Point(4, 29);
            this.masterListTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.masterListTab.Name = "masterListTab";
            this.masterListTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.masterListTab.Size = new System.Drawing.Size(1244, 991);
            this.masterListTab.TabIndex = 1;
            this.masterListTab.Text = "Master List";
            this.masterListTab.UseVisualStyleBackColor = true;
            // 
            // masterListView
            // 
            this.masterListView.AutoGenerateColumns = false;
            this.masterListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.masterListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.itemTypeDataGridViewTextBoxColumn1,
            this.brandDataGridViewTextBoxColumn1,
            this.sKUDataGridViewTextBoxColumn1,
            this.unitsOnHandDataGridViewTextBoxColumn1,
            this.itemNameDataGridViewTextBoxColumn1,
            this.priceUnitDataGridViewTextBoxColumn1,
            this.unitPriceDataGridViewTextBoxColumn1,
            this.extendedPriceDataGridViewTextBoxColumn1,
            this.createdTSDataGridViewTextBoxColumn1,
            this.updatedTSDataGridViewTextBoxColumn1});
            this.masterListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.masterListView.DataSource = this.masterInventoriesBindingSource;
            this.masterListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterListView.Location = new System.Drawing.Point(4, 67);
            this.masterListView.Name = "masterListView";
            this.masterListView.RowTemplate.Height = 24;
            this.masterListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.masterListView.Size = new System.Drawing.Size(1236, 919);
            this.masterListView.TabIndex = 6;
            this.masterListView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_MasterInventory_EndEdit);
            this.masterListView.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addRow);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 62);
            this.panel2.TabIndex = 8;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(18, 22);
            this.addRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(33, 35);
            this.addRow.TabIndex = 8;
            this.addRow.Text = "+";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master Inventory List";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inventoryTab);
            this.tabControl1.Controls.Add(this.pricingTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 1057);
            this.tabControl1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 59;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeDataGridViewTextBoxColumn.Width = 111;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 88;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            this.sKUDataGridViewTextBoxColumn.Width = 78;
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            this.unitsOnHandDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitsOnHandDataGridViewTextBoxColumn.Width = 142;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 119;
            // 
            // priceUnitDataGridViewTextBoxColumn
            // 
            this.priceUnitDataGridViewTextBoxColumn.DataPropertyName = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn.HeaderText = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn.Name = "priceUnitDataGridViewTextBoxColumn";
            this.priceUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceUnitDataGridViewTextBoxColumn.Width = 109;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 109;
            // 
            // extendedPriceDataGridViewTextBoxColumn
            // 
            this.extendedPriceDataGridViewTextBoxColumn.DataPropertyName = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn.HeaderText = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn.Name = "extendedPriceDataGridViewTextBoxColumn";
            this.extendedPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.extendedPriceDataGridViewTextBoxColumn.Width = 148;
            // 
            // createdTSDataGridViewTextBoxColumn
            // 
            this.createdTSDataGridViewTextBoxColumn.DataPropertyName = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn.HeaderText = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn.Name = "createdTSDataGridViewTextBoxColumn";
            this.createdTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdTSDataGridViewTextBoxColumn.Width = 131;
            // 
            // updatedTSDataGridViewTextBoxColumn
            // 
            this.updatedTSDataGridViewTextBoxColumn.DataPropertyName = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn.HeaderText = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn.Name = "updatedTSDataGridViewTextBoxColumn";
            this.updatedTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedTSDataGridViewTextBoxColumn.Width = 136;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemTypeDataGridViewTextBoxColumn1
            // 
            this.itemTypeDataGridViewTextBoxColumn1.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn1.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn1.Name = "itemTypeDataGridViewTextBoxColumn1";
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            // 
            // sKUDataGridViewTextBoxColumn1
            // 
            this.sKUDataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn1.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn1.Name = "sKUDataGridViewTextBoxColumn1";
            // 
            // unitsOnHandDataGridViewTextBoxColumn1
            // 
            this.unitsOnHandDataGridViewTextBoxColumn1.DataPropertyName = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn1.HeaderText = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn1.Name = "unitsOnHandDataGridViewTextBoxColumn1";
            // 
            // itemNameDataGridViewTextBoxColumn1
            // 
            this.itemNameDataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn1.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn1.Name = "itemNameDataGridViewTextBoxColumn1";
            // 
            // priceUnitDataGridViewTextBoxColumn1
            // 
            this.priceUnitDataGridViewTextBoxColumn1.DataPropertyName = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn1.HeaderText = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn1.Name = "priceUnitDataGridViewTextBoxColumn1";
            // 
            // unitPriceDataGridViewTextBoxColumn1
            // 
            this.unitPriceDataGridViewTextBoxColumn1.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.Name = "unitPriceDataGridViewTextBoxColumn1";
            // 
            // extendedPriceDataGridViewTextBoxColumn1
            // 
            this.extendedPriceDataGridViewTextBoxColumn1.DataPropertyName = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn1.HeaderText = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn1.Name = "extendedPriceDataGridViewTextBoxColumn1";
            // 
            // createdTSDataGridViewTextBoxColumn1
            // 
            this.createdTSDataGridViewTextBoxColumn1.DataPropertyName = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn1.HeaderText = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn1.Name = "createdTSDataGridViewTextBoxColumn1";
            this.createdTSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // updatedTSDataGridViewTextBoxColumn1
            // 
            this.updatedTSDataGridViewTextBoxColumn1.DataPropertyName = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn1.HeaderText = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn1.Name = "updatedTSDataGridViewTextBoxColumn1";
            this.updatedTSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsMasterInventory
            // 
            this.bsMasterInventory.DataSource = typeof(Cape_Senior_Center_Inventory_System.DTOs.InventoryModel);
            // 
            // bsCurrentInventory
            // 
            this.bsCurrentInventory.DataSource = typeof(Cape_Senior_Center_Inventory_System.DTOs.InventoryModel);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 1092);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Cape Girardeau Senior Center Inventory Management";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterInventoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.historyTab.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.inventoryHistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pricingHistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pricingHistoryDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pricingTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.inventoryTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.currentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.masterListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterListView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.BindingSource bsCurrentInventory;
        private System.Windows.Forms.BindingSource bsMasterInventory;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource masterInventoriesBindingSource;
        private DatabaseDataSetTableAdapters.MasterInventoriesTableAdapter masterInventoriesTableAdapter;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage inventoryHistoryTab;
        private System.Windows.Forms.DataGridView inventoryHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker inventoryHistoryEndDatePicker;
        private System.Windows.Forms.DateTimePicker inventoryHistoryStartDatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage pricingHistoryTab;
        private System.Windows.Forms.DataGridView pricingHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker pricingHistoryEndDatePicker;
        private System.Windows.Forms.DateTimePicker pricingHistoryStartDatePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage pricingTab;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage pricingReconcileTab;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage currentTab;
        private System.Windows.Forms.DataGridView currentInventoryView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage masterListTab;
        private System.Windows.Forms.DataGridView masterListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extendedPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceUnitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn extendedPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedTSDataGridViewTextBoxColumn1;
    }
}

