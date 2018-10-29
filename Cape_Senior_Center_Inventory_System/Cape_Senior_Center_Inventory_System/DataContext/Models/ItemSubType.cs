using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class ItemSubType
    {
        [Key]
        public int SubTypeId { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }
    }
}
