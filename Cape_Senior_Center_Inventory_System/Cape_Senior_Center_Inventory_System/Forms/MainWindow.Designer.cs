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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.masterListTab = new System.Windows.Forms.TabPage();
            this.masterListView = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeFilterBox = new System.Windows.Forms.ComboBox();
            this.termsLabel = new System.Windows.Forms.Label();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.columnFilter = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
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
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
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
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(992, 660);
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
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(992, 660);
            this.tabControl4.TabIndex = 0;
            // 
            // inventoryHistoryTab
            // 
            this.inventoryHistoryTab.Controls.Add(this.inventoryHistoryDataGridView);
            this.inventoryHistoryTab.Controls.Add(this.panel4);
            this.inventoryHistoryTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryHistoryTab.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryHistoryTab.Name = "inventoryHistoryTab";
            this.inventoryHistoryTab.Size = new System.Drawing.Size(984, 634);
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
            this.inventoryHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryHistoryDataGridView.Location = new System.Drawing.Point(0, 49);
            this.inventoryHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryHistoryDataGridView.Name = "inventoryHistoryDataGridView";
            this.inventoryHistoryDataGridView.ReadOnly = true;
            this.inventoryHistoryDataGridView.RowTemplate.Height = 24;
            this.inventoryHistoryDataGridView.Size = new System.Drawing.Size(984, 585);
            this.inventoryHistoryDataGridView.TabIndex = 3;
            this.inventoryHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryHistoryDataGridView_CellContentClick);
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
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 49);
            this.panel4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Start Date";
            // 
            // inventoryHistoryEndDatePicker
            // 
            this.inventoryHistoryEndDatePicker.CustomFormat = "";
            this.inventoryHistoryEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inventoryHistoryEndDatePicker.Location = new System.Drawing.Point(616, 20);
            this.inventoryHistoryEndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryHistoryEndDatePicker.Name = "inventoryHistoryEndDatePicker";
            this.inventoryHistoryEndDatePicker.Size = new System.Drawing.Size(91, 20);
            this.inventoryHistoryEndDatePicker.TabIndex = 2;
            this.inventoryHistoryEndDatePicker.ValueChanged += new System.EventHandler(this.inventoryHistoryEndDatePicker_ValueChanged);
            // 
            // inventoryHistoryStartDatePicker
            // 
            this.inventoryHistoryStartDatePicker.CustomFormat = "";
            this.inventoryHistoryStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inventoryHistoryStartDatePicker.Location = new System.Drawing.Point(522, 20);
            this.inventoryHistoryStartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryHistoryStartDatePicker.Name = "inventoryHistoryStartDatePicker";
            this.inventoryHistoryStartDatePicker.Size = new System.Drawing.Size(91, 20);
            this.inventoryHistoryStartDatePicker.TabIndex = 1;
            this.inventoryHistoryStartDatePicker.ValueChanged += new System.EventHandler(this.inventoryHistoryStartDatePicker_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Inventory History";
            // 
            // pricingHistoryTab
            // 
            this.pricingHistoryTab.Controls.Add(this.pricingHistoryDataGridView);
            this.pricingHistoryTab.Controls.Add(this.panel5);
            this.pricingHistoryTab.Location = new System.Drawing.Point(4, 22);
            this.pricingHistoryTab.Margin = new System.Windows.Forms.Padding(2);
            this.pricingHistoryTab.Name = "pricingHistoryTab";
            this.pricingHistoryTab.Size = new System.Drawing.Size(984, 634);
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
            this.pricingHistoryDataGridView.Location = new System.Drawing.Point(0, 49);
            this.pricingHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.pricingHistoryDataGridView.Name = "pricingHistoryDataGridView";
            this.pricingHistoryDataGridView.ReadOnly = true;
            this.pricingHistoryDataGridView.RowTemplate.Height = 24;
            this.pricingHistoryDataGridView.Size = new System.Drawing.Size(984, 585);
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
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 49);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(614, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "End Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Start Date";
            // 
            // pricingHistoryEndDatePicker
            // 
            this.pricingHistoryEndDatePicker.CustomFormat = "";
            this.pricingHistoryEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pricingHistoryEndDatePicker.Location = new System.Drawing.Point(616, 20);
            this.pricingHistoryEndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.pricingHistoryEndDatePicker.Name = "pricingHistoryEndDatePicker";
            this.pricingHistoryEndDatePicker.Size = new System.Drawing.Size(91, 20);
            this.pricingHistoryEndDatePicker.TabIndex = 2;
            // 
            // pricingHistoryStartDatePicker
            // 
            this.pricingHistoryStartDatePicker.CustomFormat = "";
            this.pricingHistoryStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pricingHistoryStartDatePicker.Location = new System.Drawing.Point(522, 20);
            this.pricingHistoryStartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.pricingHistoryStartDatePicker.Name = "pricingHistoryStartDatePicker";
            this.pricingHistoryStartDatePicker.Size = new System.Drawing.Size(91, 20);
            this.pricingHistoryStartDatePicker.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(314, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Pricing History";
            // 
            // pricingTab
            // 
            this.pricingTab.Controls.Add(this.tabControl3);
            this.pricingTab.Location = new System.Drawing.Point(4, 22);
            this.pricingTab.Margin = new System.Windows.Forms.Padding(2);
            this.pricingTab.Name = "pricingTab";
            this.pricingTab.Size = new System.Drawing.Size(992, 660);
            this.pricingTab.TabIndex = 9;
            this.pricingTab.Text = "Pricing";
            this.pricingTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.pricingReconcileTab);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(992, 660);
            this.tabControl3.TabIndex = 0;
            // 
            // pricingReconcileTab
            // 
            this.pricingReconcileTab.Location = new System.Drawing.Point(4, 22);
            this.pricingReconcileTab.Margin = new System.Windows.Forms.Padding(2);
            this.pricingReconcileTab.Name = "pricingReconcileTab";
            this.pricingReconcileTab.Padding = new System.Windows.Forms.Padding(2);
            this.pricingReconcileTab.Size = new System.Drawing.Size(984, 634);
            this.pricingReconcileTab.TabIndex = 0;
            this.pricingReconcileTab.Text = "Reconcile";
            this.pricingReconcileTab.UseVisualStyleBackColor = true;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.tabControl2);
            this.inventoryTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(992, 660);
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
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(992, 660);
            this.tabControl2.TabIndex = 0;
            // 
            // currentTab
            // 
            this.currentTab.Controls.Add(this.currentInventoryView);
            this.currentTab.Controls.Add(this.panel1);
            this.currentTab.Location = new System.Drawing.Point(4, 22);
            this.currentTab.Name = "currentTab";
            this.currentTab.Padding = new System.Windows.Forms.Padding(3);
            this.currentTab.Size = new System.Drawing.Size(984, 634);
            this.currentTab.TabIndex = 0;
            this.currentTab.Text = "Current";
            this.currentTab.UseVisualStyleBackColor = true;
            // 
            // currentInventoryView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.currentInventoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.currentInventoryView.Location = new System.Drawing.Point(3, 43);
            this.currentInventoryView.Margin = new System.Windows.Forms.Padding(2);
            this.currentInventoryView.Name = "currentInventoryView";
            this.currentInventoryView.ReadOnly = true;
            this.currentInventoryView.RowTemplate.Height = 24;
            this.currentInventoryView.Size = new System.Drawing.Size(978, 588);
            this.currentInventoryView.TabIndex = 4;
            this.currentInventoryView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView2_MasterInventory_CellBeginEdit);
            this.currentInventoryView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CurrentInventory_EndEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeDataGridViewTextBoxColumn.Width = 76;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 60;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            this.sKUDataGridViewTextBoxColumn.Width = 54;
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            this.unitsOnHandDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitsOnHandDataGridViewTextBoxColumn.Width = 96;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceUnitDataGridViewTextBoxColumn
            // 
            this.priceUnitDataGridViewTextBoxColumn.DataPropertyName = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn.HeaderText = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn.Name = "priceUnitDataGridViewTextBoxColumn";
            this.priceUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceUnitDataGridViewTextBoxColumn.Width = 75;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 75;
            // 
            // extendedPriceDataGridViewTextBoxColumn
            // 
            this.extendedPriceDataGridViewTextBoxColumn.DataPropertyName = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn.HeaderText = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn.Name = "extendedPriceDataGridViewTextBoxColumn";
            this.extendedPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.extendedPriceDataGridViewTextBoxColumn.Width = 101;
            // 
            // createdTSDataGridViewTextBoxColumn
            // 
            this.createdTSDataGridViewTextBoxColumn.DataPropertyName = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn.HeaderText = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn.Name = "createdTSDataGridViewTextBoxColumn";
            this.createdTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdTSDataGridViewTextBoxColumn.Width = 89;
            // 
            // updatedTSDataGridViewTextBoxColumn
            // 
            this.updatedTSDataGridViewTextBoxColumn.DataPropertyName = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn.HeaderText = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn.Name = "updatedTSDataGridViewTextBoxColumn";
            this.updatedTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedTSDataGridViewTextBoxColumn.Width = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 40);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Inventory";
            // 
            // masterListTab
            // 
            this.masterListTab.Controls.Add(this.clearButton);
            this.masterListTab.Controls.Add(this.columnFilter);
            this.masterListTab.Controls.Add(this.termsTextBox);
            this.masterListTab.Controls.Add(this.termsLabel);
            this.masterListTab.Controls.Add(this.typeFilterBox);
            this.masterListTab.Controls.Add(this.typeLabel);
            this.masterListTab.Controls.Add(this.masterListView);
            this.masterListTab.Controls.Add(this.panel2);
            this.masterListTab.Location = new System.Drawing.Point(4, 22);
            this.masterListTab.Name = "masterListTab";
            this.masterListTab.Padding = new System.Windows.Forms.Padding(3);
            this.masterListTab.Size = new System.Drawing.Size(984, 634);
            this.masterListTab.TabIndex = 1;
            this.masterListTab.Text = "Master List";
            this.masterListTab.UseVisualStyleBackColor = true;
            // 
            // masterListView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            this.masterListView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.masterListView.AutoGenerateColumns = false;
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
            this.masterListView.Location = new System.Drawing.Point(3, 43);
            this.masterListView.Margin = new System.Windows.Forms.Padding(2);
            this.masterListView.Name = "masterListView";
            this.masterListView.RowTemplate.Height = 24;
            this.masterListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.masterListView.Size = new System.Drawing.Size(978, 588);
            this.masterListView.TabIndex = 6;
            this.masterListView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView2_MasterInventory_CellBeginEdit);
            this.masterListView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_MasterInventory_EndEdit);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 85;
            // 
            // itemTypeDataGridViewTextBoxColumn1
            // 
            this.itemTypeDataGridViewTextBoxColumn1.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn1.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn1.Name = "itemTypeDataGridViewTextBoxColumn1";
            this.itemTypeDataGridViewTextBoxColumn1.Width = 85;
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            this.brandDataGridViewTextBoxColumn1.Width = 85;
            // 
            // sKUDataGridViewTextBoxColumn1
            // 
            this.sKUDataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn1.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn1.Name = "sKUDataGridViewTextBoxColumn1";
            this.sKUDataGridViewTextBoxColumn1.Width = 85;
            // 
            // unitsOnHandDataGridViewTextBoxColumn1
            // 
            this.unitsOnHandDataGridViewTextBoxColumn1.DataPropertyName = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn1.HeaderText = "UnitsOnHand";
            this.unitsOnHandDataGridViewTextBoxColumn1.Name = "unitsOnHandDataGridViewTextBoxColumn1";
            this.unitsOnHandDataGridViewTextBoxColumn1.Width = 85;
            // 
            // itemNameDataGridViewTextBoxColumn1
            // 
            this.itemNameDataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn1.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn1.Name = "itemNameDataGridViewTextBoxColumn1";
            this.itemNameDataGridViewTextBoxColumn1.Width = 85;
            // 
            // priceUnitDataGridViewTextBoxColumn1
            // 
            this.priceUnitDataGridViewTextBoxColumn1.DataPropertyName = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn1.HeaderText = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn1.Name = "priceUnitDataGridViewTextBoxColumn1";
            this.priceUnitDataGridViewTextBoxColumn1.Width = 85;
            // 
            // unitPriceDataGridViewTextBoxColumn1
            // 
            this.unitPriceDataGridViewTextBoxColumn1.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.Name = "unitPriceDataGridViewTextBoxColumn1";
            this.unitPriceDataGridViewTextBoxColumn1.Width = 85;
            // 
            // extendedPriceDataGridViewTextBoxColumn1
            // 
            this.extendedPriceDataGridViewTextBoxColumn1.DataPropertyName = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn1.HeaderText = "ExtendedPrice";
            this.extendedPriceDataGridViewTextBoxColumn1.Name = "extendedPriceDataGridViewTextBoxColumn1";
            this.extendedPriceDataGridViewTextBoxColumn1.Width = 85;
            // 
            // createdTSDataGridViewTextBoxColumn1
            // 
            this.createdTSDataGridViewTextBoxColumn1.DataPropertyName = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn1.HeaderText = "Created_TS";
            this.createdTSDataGridViewTextBoxColumn1.Name = "createdTSDataGridViewTextBoxColumn1";
            this.createdTSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createdTSDataGridViewTextBoxColumn1.Width = 85;
            // 
            // updatedTSDataGridViewTextBoxColumn1
            // 
            this.updatedTSDataGridViewTextBoxColumn1.DataPropertyName = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn1.HeaderText = "Updated_TS";
            this.updatedTSDataGridViewTextBoxColumn1.Name = "updatedTSDataGridViewTextBoxColumn1";
            this.updatedTSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.updatedTSDataGridViewTextBoxColumn1.Width = 85;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.addRow);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 40);
            this.panel2.TabIndex = 8;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(41, 12);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(12, 12);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(22, 23);
            this.addRow.TabIndex = 8;
            this.addRow.Text = "+";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master Inventory List";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inventoryTab);
            this.tabControl1.Controls.Add(this.pricingTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 686);
            this.tabControl1.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 69);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // typeFilterBox
            // 
            this.typeFilterBox.FormattingEnabled = true;
            this.typeFilterBox.Location = new System.Drawing.Point(53, 65);
            this.typeFilterBox.Name = "typeFilterBox";
            this.typeFilterBox.Size = new System.Drawing.Size(121, 21);
            this.typeFilterBox.TabIndex = 10;
            this.typeFilterBox.Visible = false;
            this.typeFilterBox.SelectedIndexChanged += new System.EventHandler(this.typeFilterBox_SelectedIndexChanged);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(181, 69);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(39, 13);
            this.termsLabel.TabIndex = 11;
            this.termsLabel.Text = "Terms:";
            this.termsLabel.Visible = false;
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(227, 65);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(100, 20);
            this.termsTextBox.TabIndex = 12;
            this.termsTextBox.Visible = false;
            this.termsTextBox.TextChanged += new System.EventHandler(this.termsTextBox_TextChanged);
            // 
            // columnFilter
            // 
            this.columnFilter.Enabled = false;
            this.columnFilter.FormattingEnabled = true;
            this.columnFilter.Location = new System.Drawing.Point(333, 65);
            this.columnFilter.Name = "columnFilter";
            this.columnFilter.Size = new System.Drawing.Size(121, 21);
            this.columnFilter.TabIndex = 13;
            this.columnFilter.Visible = false;
            this.columnFilter.SelectedIndexChanged += new System.EventHandler(this.columnFilter_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(460, 65);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 21);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 710);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.masterListTab.PerformLayout();
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
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.ComboBox typeFilterBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox columnFilter;
    }
}

