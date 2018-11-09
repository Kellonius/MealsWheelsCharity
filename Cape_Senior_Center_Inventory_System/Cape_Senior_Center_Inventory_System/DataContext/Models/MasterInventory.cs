using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class MasterInventory
    {
        [Key]
        public int Id { get; set; }
        public string ItemType { get; set; }
        public string SubType { get; set; }
        public string Brand { get; set; }
        public string SKU { get; set; }
        public int UnitsOnHand { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ItemName { get; set; }
        public double PriceUnit { get; set; }
        public double UnitPrice { get; set; }
        public double ExtendedPrice { get; set; }
        public DateTime Created_TS { get; set; }
        public DateTime Updated_TS { get; set; }
    }
}
