using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class Price
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public double Cost { get; set; }
        public DateTime EffectiveDate { get; set; }

        public DateTime Created_TS { get; set; }
        public DateTime Updated_TS { get; set; }

        public virtual Item Item { get; set; }

    }
}
