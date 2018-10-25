namespace Cape_Senior_Center_Inventory_System.DataContext
{
    using Cape_Senior_Center_Inventory_System.DataContext.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        private static string location =
            "C:\\Projects\\MealsWheelsCharity\\Cape_Senior_Center_Inventory_System\\Cape_Senior_Center_Inventory_System\\";

        private static string connectionString = string.Format(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}Database\Database.mdf;Integrated Security=True",
            location);
        //Database name will be populated when app is running. Undo this. 
          // AppDomain.CurrentDomain.BaseDirectory);
        public DataContext()
            : base(connectionString)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasures{ get; set; }
        public virtual DbSet<MasterInventory> MasterInventories { get; set; }
        public virtual DbSet<InventoryHistory> InventoryHistory { get; set; }
    }

}