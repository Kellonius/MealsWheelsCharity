using System;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int Weight { get; set; }

        public DateTime Created_TS { get; set; }
        public DateTime? Updated_TS { get; set; }
    }
}
