using System;

namespace Cape_Senior_Center_Inventory_System.DemoStuff
{
    public class User_Linked_Org
    {
        public string User_GUID { get; set; }
        public string Member_ID { get; set; }
        public string Alliance_ID { get; set; }
        public bool? IsPrimary { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreateBy { get; set; }
    }
}
