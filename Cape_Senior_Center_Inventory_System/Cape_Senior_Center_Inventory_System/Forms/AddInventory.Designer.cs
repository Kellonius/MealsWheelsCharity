namespace Cape_Senior_Center_Inventory_System.Forms
{
    partial class AddInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uomBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priceUnitBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.unitPriceBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.exPriceBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.subTypeBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item Type:";
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Location = new System.Drawing.Point(68, 23);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(121, 21);
            this.itemTypeBox.TabIndex = 0;
            this.itemTypeBox.SelectedIndexChanged += new System.EventHandler(this.itemTypeBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(68, 39);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(121, 20);
            this.brandTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "SKU:";
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(68, 65);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(121, 20);
            this.skuTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item Name:";
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(68, 13);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(121, 20);
            this.itemNameBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Units On Hand:";
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(99, 19);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Unit Of Measure:";
            // 
            // uomBox
            // 
            this.uomBox.Location = new System.Drawing.Point(99, 45);
            this.uomBox.Name = "uomBox";
            this.uomBox.Size = new System.Drawing.Size(100, 20);
            this.uomBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Price Unit:";
            // 
            // priceUnitBox
            // 
            this.priceUnitBox.Location = new System.Drawing.Point(68, 19);
            this.priceUnitBox.Name = "priceUnitBox";
            this.priceUnitBox.Size = new System.Drawing.Size(127, 20);
            this.priceUnitBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Unit Price:";
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Location = new System.Drawing.Point(70, 45);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.Size = new System.Drawing.Size(125, 20);
            this.unitPriceBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Extended Price:";
            // 
            // exPriceBox
            // 
            this.exPriceBox.Location = new System.Drawing.Point(95, 72);
            this.exPriceBox.Name = "exPriceBox";
            this.exPriceBox.Size = new System.Drawing.Size(100, 20);
            this.exPriceBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(208, 316);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(384, 316);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sub-Type:";
            // 
            // subTypeBox
            // 
            this.subTypeBox.Enabled = false;
            this.subTypeBox.FormattingEnabled = true;
            this.subTypeBox.Location = new System.Drawing.Point(68, 50);
            this.subTypeBox.Name = "subTypeBox";
            this.subTypeBox.Size = new System.Drawing.Size(121, 21);
            this.subTypeBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.subTypeBox);
            this.groupBox1.Controls.Add(this.itemTypeBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(83, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Type Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.priceUnitBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.unitPriceBox);
            this.groupBox2.Controls.Add(this.exPriceBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(384, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.itemNameBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.brandTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.skuTextBox);
            this.groupBox3.Location = new System.Drawing.Point(83, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.unitsTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.uomBox);
            this.groupBox4.Location = new System.Drawing.Point(384, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 85);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inventory Control";
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 379);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddInventory";
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uomBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceUnitBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unitPriceBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox exPriceBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox subTypeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}