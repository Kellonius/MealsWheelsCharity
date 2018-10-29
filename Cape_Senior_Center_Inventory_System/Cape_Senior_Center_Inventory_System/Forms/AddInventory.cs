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
        public DataContext.DataContext context = new DataContext.DataContext();


        private void AddInventory_Load(object sender, EventArgs e)
        {
            MasterList = context.MasterInventories.ToList();
            InventoryHistory = context.InventoryHistory.ToList();
            itemTypeBox.Items.AddRange(context.ItemType.Select(x => x.Description).ToArray());
        }
        public AddInventory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addItem();
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addItem()
        {
            context.MasterInventories.Add(new MasterInventory()
            {
                ItemType = itemTypeBox.Text,
                Brand = brandTextBox.Text,
                SKU = skuTextBox.Text,
                UnitsOnHand = Convert.ToInt32(unitsTextBox.Text),
                ItemName = itemNameBox.Text,
                PriceUnit = Convert.ToDouble(priceUnitBox.Text),
                UnitPrice = Convert.ToDouble(unitPriceBox.Text),
                ExtendedPrice = Convert.ToDouble(exPriceBox.Text),
                Created_TS = DateTime.Now,
                Updated_TS = DateTime.Now,
            });
            context.SaveChanges();
            addHistory();
        }

        private void addHistory()
        {
            var data = context.MasterInventories.OrderByDescending(x => x.Id).Select(x => x.Id).First().ToString();
            context.InventoryHistory.Add(new InventoryHistory()
            {
                ItemId = Convert.ToInt32(data),
                ItemName = itemNameBox.Text,
                PreviousUnitsOnHand = 0,
                NewUnitsOnHand = Convert.ToInt32(unitsTextBox.Text),
                Updated_TS = DateTime.Now
            });
            context.SaveChanges();

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

    }
}
