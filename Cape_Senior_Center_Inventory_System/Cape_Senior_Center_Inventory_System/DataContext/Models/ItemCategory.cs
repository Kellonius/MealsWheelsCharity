using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class ItemCategory
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public DateTime Created_TS { get; set; }
        public DateTime Updated_TS { get; set; }

        public virtual Item Item { get; set; }
        public virtual Category Category { get; set; }
    }
}
