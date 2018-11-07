using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class ReconciliationModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int RunningAmount { get; set; }
        public double UnitPrice { get; set; }
        public double Total { get; set; }
    }
}
