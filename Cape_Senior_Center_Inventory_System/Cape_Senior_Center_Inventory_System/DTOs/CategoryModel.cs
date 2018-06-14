using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DTOs
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int Weight { get; set; }

        public DateTime Created_TS { get; set; }
        public DateTime Updated_TS { get; set; }
    }
}
