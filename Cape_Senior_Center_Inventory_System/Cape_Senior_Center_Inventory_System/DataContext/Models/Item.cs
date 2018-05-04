using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("UnitOfMeasure")]
        public int UomId { get; set; }

        public DateTime Created_TS { get; set; }
        public DateTime Updated_TS { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

    }
}
