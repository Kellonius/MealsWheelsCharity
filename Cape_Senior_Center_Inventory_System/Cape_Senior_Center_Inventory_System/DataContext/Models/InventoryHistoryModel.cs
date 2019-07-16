using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class InventoryHistoryModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double CurrentPrice { get; set; }
        public int PreviousUnitsOnHand { get; set; }
        public int NewUnitsOnHand { get; set; }
        public DateTime Updated_TS { get; set; }

    }
}
