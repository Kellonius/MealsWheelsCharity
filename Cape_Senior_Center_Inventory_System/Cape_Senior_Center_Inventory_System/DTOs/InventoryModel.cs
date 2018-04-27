using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DTOs
{
    public class InventoryModel
    {
        public int Id { get; set; }
        public string inventoryName { get; set; }
        public string inventoryId { get; set; }
        public string quantity { get; set; }
    }
}
