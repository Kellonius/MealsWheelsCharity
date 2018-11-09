using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Cape_Senior_Center_Inventory_System.DataContext.Models;

namespace Cape_Senior_Center_Inventory_System.Forms
{

    public partial class AddInventory : Form
    {

        public List<MasterInventory> MasterList = new List<MasterInventory>();
        public List<InventoryHistory> InventoryHistory = new List<InventoryHistory>();
        public MasterInventory lineItem = new MasterInventory();
        public DataContext.DataContext context = new DataContext.DataContext();
        public bool editMode = false;
        public int previousUnits = 0;

        public AddInventory()
        {
            InitializeComponent();
        }
        private void AddInventory_Load(object sender, EventArgs e)
        {
            MasterList = context.MasterInventories.ToList();
            InventoryHistory = context.InventoryHistory.ToList();
            itemTypeBox.Items.AddRange(context.ItemType.Select(x => x.Description).ToArray());
        }

        #region Helper Methods
        public void prepareEdit(int id)
        {
            lineItem = context.MasterInventories.Where(x => x.Id == id).FirstOrDefault();
            itemTypeBox.Text = lineItem.ItemType;
            brandTextBox.Text = lineItem.Brand;
            skuTextBox.Text = lineItem.SKU;
            unitsTextBox.Text = lineItem.UnitsOnHand.ToString();
            itemNameBox.Text = lineItem.ItemName;
            priceUnitBox.Text = lineItem.PriceUnit.ToString();
            unitPriceBox.Text = lineItem.UnitPrice.ToString();
            exPriceBox.Text = lineItem.ExtendedPrice.ToString();
            subTypeBox.Enabled = true;
            subTypeBox.Text = lineItem.SubType;
            uomBox.Text = lineItem.UnitOfMeasure;
            editMode = true;
            addButton.Text = "Edit";
            previousUnits = lineItem.UnitsOnHand;
        }

        private void addItem()
        {
            context.MasterInventories.Add(new MasterInventory()
            {
                ItemType = itemTypeBox.Text,
                SubType = subTypeBox.Text,
                Brand = brandTextBox.Text,
                SKU = skuTextBox.Text,
                UnitsOnHand = Convert.ToInt32(unitsTextBox.Text),
                ItemName = itemNameBox.Text,
                PriceUnit = Convert.ToDouble(priceUnitBox.Text),
                UnitPrice = Convert.ToDouble(unitPriceBox.Text),
                ExtendedPrice = Convert.ToDouble(exPriceBox.Text),
                UnitOfMeasure = uomBox.Text,
                Created_TS = DateTime.Now,
                Updated_TS = DateTime.Now,
            });
            context.SaveChanges();
            addHistory(previousUnits);
        }

        private void addHistory(int prevUnits)
        {
            var data = context.MasterInventories.OrderByDescending(x => x.Id).Select(x => x.Id).First().ToString();
            context.InventoryHistory.Add(new InventoryHistory()
            {
                ItemId = Convert.ToInt32(data),
                ItemName = itemNameBox.Text,
                CurrentPrice = Convert.ToDouble(unitPriceBox.Text),
                PreviousUnitsOnHand = prevUnits,
                NewUnitsOnHand = Convert.ToInt32(unitsTextBox.Text),
                Updated_TS = DateTime.Now
            });
            context.SaveChanges();
        }
        #endregion

        #region Button Clicks and Dropdowns
        private void addButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                lineItem.ItemType = itemTypeBox.Text;
                lineItem.SubType = subTypeBox.Text;
                lineItem.Brand = brandTextBox.Text;
                lineItem.SKU = skuTextBox.Text;
                lineItem.UnitsOnHand = Convert.ToInt32(unitsTextBox.Text);
                lineItem.ItemName = itemNameBox.Text;
                lineItem.PriceUnit = Convert.ToDouble(priceUnitBox.Text);
                lineItem.UnitPrice = Convert.ToDouble(unitPriceBox.Text);
                lineItem.ExtendedPrice = Convert.ToDouble(exPriceBox.Text);
                lineItem.UnitOfMeasure = uomBox.Text;
                lineItem.Updated_TS = DateTime.Now;
                context.SaveChanges();
                addHistory(previousUnits);
            }
            else
            {
                addItem();
            }

            this.Dispose();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void itemTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zeroIndex = context.ItemSubType.Where(x => x.TypeId == 1).Select(x => x.Description).ToList(); //{ "Beef", "Chicken", "Fish", "Pork", "Turkey", "Eggs", "Other Entrees", "Breads", "Desserts", "Other", "Vegetables" };
            var oneIndex = context.ItemSubType.Where(x => x.TypeId == 2).Select(x => x.Description).ToList(); //{ "Dairy", "Soup Bases", "Produce" };
            var twoIndex = context.ItemSubType.Where(x => x.TypeId == 3).Select(x => x.Description).ToList();
            //{
            //    "Canned", "Meats", "Gallons", "Baking Items", "Baking Mixes", "Jello", "Pudding/Pie Mixes",
            //    "Gravy Mixes", "Chips", "Other Dry Items", "Pasta", "PC Condiments"
            //};
            subTypeBox.Enabled = true;
            subTypeBox.Items.Clear();
            if (itemTypeBox.SelectedIndex == 0)
            {
                subTypeBox.Items.AddRange(zeroIndex.ToArray());
            }
            else if (itemTypeBox.SelectedIndex == 1)
            {
                subTypeBox.Items.AddRange(oneIndex.ToArray());
            }
            else if (itemTypeBox.SelectedIndex == 2)
            {
                subTypeBox.Items.AddRange(twoIndex.ToArray());
            }
        }
        #endregion
    }
}
