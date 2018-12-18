using System;
using System.Drawing;
using Cape_Senior_Center_Inventory_System.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reportTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.currentTab = new System.Windows.Forms.TabPage();
            this.currentInventoryGrid4 = new System.Windows.Forms.DataGridView();
            this.currentInventoryGrid3 = new System.Windows.Forms.DataGridView();
            this.currentInventoryGrid2 = new System.Windows.Forms.DataGridView();
            this.currentColumnFilter = new System.Windows.Forms.ComboBox();
            this.currentTextbox = new System.Windows.Forms.TextBox();
            this.currentTermsLabel = new System.Windows.Forms.Label();
            this.currentTypeDropdown = new System.Windows.Forms.ComboBox();
            this.currentTypeLabel = new System.Windows.Forms.Label();
            this.currentInventoryView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentEditButton = new System.Windows.Forms.Button();
            this.currentFilterButton = new System.Windows.Forms.Button();
            this.currentAddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currentClear = new System.Windows.Forms.Button();
            this.masterListTab = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.columnFilter = new System.Windows.Forms.ComboBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.termsLabel = new System.Windows.Forms.Label();
            this.typeFilterBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.masterListView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.masterEditButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.masterInventoriesTableAdapter1 = new Cape_Senior_Center_Inventory_System.DatabaseDataSetTableAdapters.MasterInventoriesTableAdapter();
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
            this.pricingReconcileTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.currentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryGrid2)).BeginInit();
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
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.addItemToolStripMenuItem.Text = "&Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
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
            this.historyTab.Location = new System.Drawing.Point(4, 25);
            this.historyTab.Margin = new System.Windows.Forms.Padding(4);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(1325, 817);
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
            this.tabControl4.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1325, 817);
            this.tabControl4.TabIndex = 0;
            // 
            // inventoryHistoryTab
            // 
            this.inventoryHistoryTab.Controls.Add(this.inventoryHistoryDataGridView);
            this.inventoryHistoryTab.Controls.Add(this.panel4);
            this.inventoryHistoryTab.Location = new System.Drawing.Point(4, 25);
            this.inventoryHistoryTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryHistoryTab.Name = "inventoryHistoryTab";
            this.inventoryHistoryTab.Size = new System.Drawing.Size(1317, 788);
            this.inventoryHistoryTab.TabIndex = 2;
            this.inventoryHistoryTab.Text = "Inventory";
            this.inventoryHistoryTab.UseVisualStyleBackColor = true;
            // 
            // inventoryHistoryDataGridView
            // 
            this.inventoryHistoryDataGridView.AllowUserToAddRows = false;
            this.inventoryHistoryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.inventoryHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventoryHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryHistoryDataGridView.Location = new System.Drawing.Point(0, 60);
            this.inventoryHistoryDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryHistoryDataGridView.Name = "inventoryHistoryDataGridView";
            this.inventoryHistoryDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryHistoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.inventoryHistoryDataGridView.RowTemplate.Height = 24;
            this.inventoryHistoryDataGridView.Size = new System.Drawing.Size(1317, 728);
            this.inventoryHistoryDataGridView.TabIndex = 3;
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
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1317, 60);
            this.panel4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(819, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Start Date";
            // 
            // inventoryHistoryEndDatePicker
            // 
            this.inventoryHistoryEndDatePicker.CustomFormat = "";
            this.inventoryHistoryEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inventoryHistoryEndDatePicker.Location = new System.Drawing.Point(821, 25);
            this.inventoryHistoryEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryHistoryEndDatePicker.Name = "inventoryHistoryEndDatePicker";
            this.inventoryHistoryEndDatePicker.Size = new System.Drawing.Size(120, 22);
            this.inventoryHistoryEndDatePicker.TabIndex = 2;
            this.inventoryHistoryEndDatePicker.ValueChanged += new System.EventHandler(this.inventoryHistoryEndDatePicker_ValueChanged);
            // 
            // inventoryHistoryStartDatePicker
            // 
            this.inventoryHistoryStartDatePicker.CustomFormat = "";
            this.inventoryHistoryStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inventoryHistoryStartDatePicker.Location = new System.Drawing.Point(696, 25);
            this.inventoryHistoryStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryHistoryStartDatePicker.Name = "inventoryHistoryStartDatePicker";
            this.inventoryHistoryStartDatePicker.Size = new System.Drawing.Size(120, 22);
            this.inventoryHistoryStartDatePicker.TabIndex = 1;
            this.inventoryHistoryStartDatePicker.ValueChanged += new System.EventHandler(this.inventoryHistoryStartDatePicker_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(408, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Inventory History";
            // 
            // pricingHistoryTab
            // 
            this.pricingHistoryTab.Controls.Add(this.pricingHistoryDataGridView);
            this.pricingHistoryTab.Controls.Add(this.panel5);
            this.pricingHistoryTab.Location = new System.Drawing.Point(4, 25);
            this.pricingHistoryTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingHistoryTab.Name = "pricingHistoryTab";
            this.pricingHistoryTab.Size = new System.Drawing.Size(1317, 788);
            this.pricingHistoryTab.TabIndex = 1;
            this.pricingHistoryTab.Text = "Pricing";
            this.pricingHistoryTab.UseVisualStyleBackColor = true;
            // 
            // pricingHistoryDataGridView
            // 
            this.pricingHistoryDataGridView.AllowUserToAddRows = false;
            this.pricingHistoryDataGridView.AllowUserToDeleteRows = false;
            this.pricingHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricingHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pricingHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.pricingHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricingHistoryDataGridView.Location = new System.Drawing.Point(0, 60);
            this.pricingHistoryDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingHistoryDataGridView.Name = "pricingHistoryDataGridView";
            this.pricingHistoryDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricingHistoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.pricingHistoryDataGridView.RowTemplate.Height = 24;
            this.pricingHistoryDataGridView.Size = new System.Drawing.Size(1317, 728);
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
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1317, 60);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(819, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "End Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Start Date";
            // 
            // pricingHistoryEndDatePicker
            // 
            this.pricingHistoryEndDatePicker.CustomFormat = "";
            this.pricingHistoryEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pricingHistoryEndDatePicker.Location = new System.Drawing.Point(821, 25);
            this.pricingHistoryEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingHistoryEndDatePicker.Name = "pricingHistoryEndDatePicker";
            this.pricingHistoryEndDatePicker.Size = new System.Drawing.Size(120, 22);
            this.pricingHistoryEndDatePicker.TabIndex = 2;
            // 
            // pricingHistoryStartDatePicker
            // 
            this.pricingHistoryStartDatePicker.CustomFormat = "";
            this.pricingHistoryStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pricingHistoryStartDatePicker.Location = new System.Drawing.Point(696, 25);
            this.pricingHistoryStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingHistoryStartDatePicker.Name = "pricingHistoryStartDatePicker";
            this.pricingHistoryStartDatePicker.Size = new System.Drawing.Size(120, 22);
            this.pricingHistoryStartDatePicker.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(419, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Pricing History";
            // 
            // pricingTab
            // 
            this.pricingTab.Controls.Add(this.tabControl3);
            this.pricingTab.Location = new System.Drawing.Point(4, 25);
            this.pricingTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingTab.Name = "pricingTab";
            this.pricingTab.Size = new System.Drawing.Size(1325, 817);
            this.pricingTab.TabIndex = 9;
            this.pricingTab.Text = "Pricing";
            this.pricingTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.pricingReconcileTab);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1325, 817);
            this.tabControl3.TabIndex = 0;
            // 
            // pricingReconcileTab
            // 
            this.pricingReconcileTab.Controls.Add(this.reportTextBox);
            this.pricingReconcileTab.Controls.Add(this.panel3);
            this.pricingReconcileTab.Location = new System.Drawing.Point(4, 25);
            this.pricingReconcileTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingReconcileTab.Name = "pricingReconcileTab";
            this.pricingReconcileTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricingReconcileTab.Size = new System.Drawing.Size(1317, 788);
            this.pricingReconcileTab.TabIndex = 0;
            this.pricingReconcileTab.Text = "Reconcile";
            this.pricingReconcileTab.UseVisualStyleBackColor = true;
            // 
            // reportTextBox
            // 
            this.reportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.reportTextBox.Location = new System.Drawing.Point(0, 71);
            this.reportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(1304, 702);
            this.reportTextBox.TabIndex = 1;
            this.reportTextBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.generateButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.endDatePicker);
            this.panel3.Controls.Add(this.startDatePicker);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 64);
            this.panel3.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(1132, 21);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 28);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1001, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(1004, 22);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(120, 22);
            this.endDatePicker.TabIndex = 6;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(879, 22);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(120, 22);
            this.startDatePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price Reconciliation and Reporting";
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.tabControl2);
            this.inventoryTab.Location = new System.Drawing.Point(4, 25);
            this.inventoryTab.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(1325, 817);
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
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1325, 817);
            this.tabControl2.TabIndex = 0;
            // 
            // currentTab
            // 
            this.currentTab.Controls.Add(this.currentInventoryGrid4);
            this.currentTab.Controls.Add(this.currentInventoryGrid3);
            this.currentTab.Controls.Add(this.currentInventoryGrid2);
            this.currentTab.Controls.Add(this.currentColumnFilter);
            this.currentTab.Controls.Add(this.currentTextbox);
            this.currentTab.Controls.Add(this.currentTermsLabel);
            this.currentTab.Controls.Add(this.currentTypeDropdown);
            this.currentTab.Controls.Add(this.currentTypeLabel);
            this.currentTab.Controls.Add(this.currentInventoryView);
            this.currentTab.Controls.Add(this.panel1);
            this.currentTab.Controls.Add(this.currentClear);
            this.currentTab.Location = new System.Drawing.Point(4, 25);
            this.currentTab.Margin = new System.Windows.Forms.Padding(4);
            this.currentTab.Name = "currentTab";
            this.currentTab.Padding = new System.Windows.Forms.Padding(4);
            this.currentTab.Size = new System.Drawing.Size(1317, 788);
            this.currentTab.TabIndex = 0;
            this.currentTab.Text = "Current";
            this.currentTab.UseVisualStyleBackColor = true;
            // 
            // currentInventoryGrid4
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lavender;
            this.currentInventoryGrid4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.currentInventoryGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.currentInventoryGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentInventoryGrid4.DefaultCellStyle = dataGridViewCellStyle10;
            this.currentInventoryGrid4.Location = new System.Drawing.Point(495, 315);
            this.currentInventoryGrid4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentInventoryGrid4.Name = "currentInventoryGrid4";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryGrid4.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.currentInventoryGrid4.RowTemplate.Height = 24;
            this.currentInventoryGrid4.Size = new System.Drawing.Size(823, 475);
            this.currentInventoryGrid4.TabIndex = 23;
            this.currentInventoryGrid4.Visible = false;
            // 
            // currentInventoryGrid3
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            this.currentInventoryGrid3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.currentInventoryGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.currentInventoryGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentInventoryGrid3.DefaultCellStyle = dataGridViewCellStyle14;
            this.currentInventoryGrid3.Location = new System.Drawing.Point(4, 317);
            this.currentInventoryGrid3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentInventoryGrid3.Name = "currentInventoryGrid3";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.currentInventoryGrid3.RowTemplate.Height = 24;
            this.currentInventoryGrid3.Size = new System.Drawing.Size(823, 475);
            this.currentInventoryGrid3.TabIndex = 22;
            this.currentInventoryGrid3.Visible = false;
            // 
            // currentInventoryGrid2
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Lavender;
            this.currentInventoryGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.currentInventoryGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.currentInventoryGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentInventoryGrid2.DefaultCellStyle = dataGridViewCellStyle18;
            this.currentInventoryGrid2.Location = new System.Drawing.Point(487, 59);
            this.currentInventoryGrid2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentInventoryGrid2.Name = "currentInventoryGrid2";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.currentInventoryGrid2.RowTemplate.Height = 24;
            this.currentInventoryGrid2.Size = new System.Drawing.Size(823, 475);
            this.currentInventoryGrid2.TabIndex = 21;
            this.currentInventoryGrid2.Visible = false;
            // 
            // currentColumnFilter
            // 
            this.currentColumnFilter.Enabled = false;
            this.currentColumnFilter.FormattingEnabled = true;
            this.currentColumnFilter.Location = new System.Drawing.Point(444, 80);
            this.currentColumnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.currentColumnFilter.Name = "currentColumnFilter";
            this.currentColumnFilter.Size = new System.Drawing.Size(160, 24);
            this.currentColumnFilter.TabIndex = 19;
            this.currentColumnFilter.Visible = false;
            this.currentColumnFilter.SelectedIndexChanged += new System.EventHandler(this.currentColumnFilter_SelectedIndexChanged);
            // 
            // currentTextbox
            // 
            this.currentTextbox.Location = new System.Drawing.Point(303, 80);
            this.currentTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.currentTextbox.Name = "currentTextbox";
            this.currentTextbox.Size = new System.Drawing.Size(132, 22);
            this.currentTextbox.TabIndex = 18;
            this.currentTextbox.Visible = false;
            this.currentTextbox.TextChanged += new System.EventHandler(this.currentTextbox_TextChanged);
            // 
            // currentTermsLabel
            // 
            this.currentTermsLabel.AutoSize = true;
            this.currentTermsLabel.Location = new System.Drawing.Point(241, 85);
            this.currentTermsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTermsLabel.Name = "currentTermsLabel";
            this.currentTermsLabel.Size = new System.Drawing.Size(52, 17);
            this.currentTermsLabel.TabIndex = 17;
            this.currentTermsLabel.Text = "Terms:";
            this.currentTermsLabel.Visible = false;
            // 
            // currentTypeDropdown
            // 
            this.currentTypeDropdown.FormattingEnabled = true;
            this.currentTypeDropdown.Location = new System.Drawing.Point(71, 80);
            this.currentTypeDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.currentTypeDropdown.Name = "currentTypeDropdown";
            this.currentTypeDropdown.Size = new System.Drawing.Size(160, 24);
            this.currentTypeDropdown.TabIndex = 16;
            this.currentTypeDropdown.Visible = false;
            this.currentTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.currentTypeDropdown_SelectedIndexChanged);
            // 
            // currentTypeLabel
            // 
            this.currentTypeLabel.AutoSize = true;
            this.currentTypeLabel.Location = new System.Drawing.Point(16, 85);
            this.currentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTypeLabel.Name = "currentTypeLabel";
            this.currentTypeLabel.Size = new System.Drawing.Size(44, 17);
            this.currentTypeLabel.TabIndex = 15;
            this.currentTypeLabel.Text = "Type:";
            this.currentTypeLabel.Visible = false;
            // 
            // currentInventoryView
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Lavender;
            this.currentInventoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.currentInventoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.currentInventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentInventoryView.DefaultCellStyle = dataGridViewCellStyle22;
            this.currentInventoryView.Location = new System.Drawing.Point(4, 53);
            this.currentInventoryView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentInventoryView.Name = "currentInventoryView";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentInventoryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.currentInventoryView.RowTemplate.Height = 24;
            this.currentInventoryView.Size = new System.Drawing.Size(823, 475);
            this.currentInventoryView.TabIndex = 4;
            this.currentInventoryView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.currentInventoryView_CellBeginEdit);
            this.currentInventoryView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentInventoryView_CellClick);
            this.currentInventoryView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CurrentInventory_EndEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentEditButton);
            this.panel1.Controls.Add(this.currentFilterButton);
            this.panel1.Controls.Add(this.currentAddButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 49);
            this.panel1.TabIndex = 6;
            // 
            // currentEditButton
            // 
            this.currentEditButton.Location = new System.Drawing.Point(161, 15);
            this.currentEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.currentEditButton.Name = "currentEditButton";
            this.currentEditButton.Size = new System.Drawing.Size(100, 28);
            this.currentEditButton.TabIndex = 11;
            this.currentEditButton.Text = "Edit";
            this.currentEditButton.UseVisualStyleBackColor = true;
            this.currentEditButton.Click += new System.EventHandler(this.currentEditButton_Click);
            // 
            // currentFilterButton
            // 
            this.currentFilterButton.Location = new System.Drawing.Point(53, 15);
            this.currentFilterButton.Margin = new System.Windows.Forms.Padding(4);
            this.currentFilterButton.Name = "currentFilterButton";
            this.currentFilterButton.Size = new System.Drawing.Size(100, 28);
            this.currentFilterButton.TabIndex = 10;
            this.currentFilterButton.Text = "Filter";
            this.currentFilterButton.UseVisualStyleBackColor = true;
            this.currentFilterButton.Click += new System.EventHandler(this.currentFilterButton_Click);
            // 
            // currentAddButton
            // 
            this.currentAddButton.Location = new System.Drawing.Point(16, 15);
            this.currentAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.currentAddButton.Name = "currentAddButton";
            this.currentAddButton.Size = new System.Drawing.Size(29, 28);
            this.currentAddButton.TabIndex = 9;
            this.currentAddButton.Text = "+";
            this.currentAddButton.UseVisualStyleBackColor = true;
            this.currentAddButton.Click += new System.EventHandler(this.addRow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Inventory";
            // 
            // currentClear
            // 
            this.currentClear.Location = new System.Drawing.Point(613, 80);
            this.currentClear.Margin = new System.Windows.Forms.Padding(4);
            this.currentClear.Name = "currentClear";
            this.currentClear.Size = new System.Drawing.Size(100, 26);
            this.currentClear.TabIndex = 20;
            this.currentClear.Text = "Clear";
            this.currentClear.UseVisualStyleBackColor = true;
            this.currentClear.Visible = false;
            this.currentClear.Click += new System.EventHandler(this.currentClear_Click);
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
            this.masterListTab.Location = new System.Drawing.Point(4, 25);
            this.masterListTab.Margin = new System.Windows.Forms.Padding(4);
            this.masterListTab.Name = "masterListTab";
            this.masterListTab.Padding = new System.Windows.Forms.Padding(4);
            this.masterListTab.Size = new System.Drawing.Size(1317, 788);
            this.masterListTab.TabIndex = 1;
            this.masterListTab.Text = "Master List";
            this.masterListTab.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(613, 79);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 26);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // columnFilter
            // 
            this.columnFilter.Enabled = false;
            this.columnFilter.FormattingEnabled = true;
            this.columnFilter.Location = new System.Drawing.Point(444, 79);
            this.columnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.columnFilter.Name = "columnFilter";
            this.columnFilter.Size = new System.Drawing.Size(160, 24);
            this.columnFilter.TabIndex = 13;
            this.columnFilter.Visible = false;
            this.columnFilter.SelectedIndexChanged += new System.EventHandler(this.columnFilter_SelectedIndexChanged);
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(303, 79);
            this.termsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(132, 22);
            this.termsTextBox.TabIndex = 12;
            this.termsTextBox.Visible = false;
            this.termsTextBox.TextChanged += new System.EventHandler(this.termsTextBox_TextChanged);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(241, 84);
            this.termsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(52, 17);
            this.termsLabel.TabIndex = 11;
            this.termsLabel.Text = "Terms:";
            this.termsLabel.Visible = false;
            // 
            // typeFilterBox
            // 
            this.typeFilterBox.FormattingEnabled = true;
            this.typeFilterBox.Location = new System.Drawing.Point(71, 79);
            this.typeFilterBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeFilterBox.Name = "typeFilterBox";
            this.typeFilterBox.Size = new System.Drawing.Size(160, 24);
            this.typeFilterBox.TabIndex = 10;
            this.typeFilterBox.Visible = false;
            this.typeFilterBox.SelectedIndexChanged += new System.EventHandler(this.typeFilterBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(16, 84);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // masterListView
            // 
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Lavender;
            this.masterListView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masterListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.masterListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterListView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.masterListView.DefaultCellStyle = dataGridViewCellStyle26;
            this.masterListView.Location = new System.Drawing.Point(4, 53);
            this.masterListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masterListView.Name = "masterListView";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masterListView.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.masterListView.RowTemplate.Height = 24;
            this.masterListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.masterListView.Size = new System.Drawing.Size(743, 391);
            this.masterListView.TabIndex = 6;
            this.masterListView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView2_MasterInventory_CellBeginEdit);
            this.masterListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.masterListView_CellClick);
            this.masterListView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_MasterInventory_EndEdit);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.masterEditButton);
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.addRow);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 49);
            this.panel2.TabIndex = 8;
            // 
            // masterEditButton
            // 
            this.masterEditButton.Location = new System.Drawing.Point(161, 15);
            this.masterEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.masterEditButton.Name = "masterEditButton";
            this.masterEditButton.Size = new System.Drawing.Size(100, 28);
            this.masterEditButton.TabIndex = 10;
            this.masterEditButton.Text = "Edit";
            this.masterEditButton.UseVisualStyleBackColor = true;
            this.masterEditButton.Click += new System.EventHandler(this.masterEditButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(53, 15);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(100, 28);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(16, 15);
            this.addRow.Margin = new System.Windows.Forms.Padding(4);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(29, 28);
            this.addRow.TabIndex = 8;
            this.addRow.Text = "+";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master Inventory List";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inventoryTab);
            this.tabControl1.Controls.Add(this.pricingTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1333, 846);
            this.tabControl1.TabIndex = 1;
            // 
            // masterInventoriesTableAdapter1
            // 
            this.masterInventoriesTableAdapter1.ClearBeforeFill = true;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 874);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
            this.pricingReconcileTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.inventoryTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.currentTab.ResumeLayout(false);
            this.currentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentInventoryGrid2)).EndInit();
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
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.ComboBox typeFilterBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox columnFilter;
        private System.Windows.Forms.Button currentFilterButton;
        private System.Windows.Forms.Button currentAddButton;
        private System.Windows.Forms.Button currentClear;
        private System.Windows.Forms.ComboBox currentColumnFilter;
        private System.Windows.Forms.TextBox currentTextbox;
        private System.Windows.Forms.Label currentTermsLabel;
        private System.Windows.Forms.ComboBox currentTypeDropdown;
        private System.Windows.Forms.Label currentTypeLabel;
        private System.Windows.Forms.Button masterEditButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox reportTextBox;
        private DatabaseDataSetTableAdapters.MasterInventoriesTableAdapter masterInventoriesTableAdapter1;
        private System.Windows.Forms.Button currentEditButton;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.DataGridView currentInventoryGrid4;
        private System.Windows.Forms.DataGridView currentInventoryGrid3;
        private System.Windows.Forms.DataGridView currentInventoryGrid2;
    }
}

