using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DataContext.Models
{
    public class Preferences
    {
            [Key]
            public int Id { get; set; }
            public int NumCurrentGrids { get; set; }
            public string CurrentColumnOne { get; set; }
            public string CurrentColumnTwo { get; set; }
            public string CurrentColumnThree { get; set; }
            public string CurrentColumnFour { get; set; }
            public int NumMasterGrids { get; set; }
            public string MasterColumnOne { get; set; }
            public string MasterColumnTwo { get; set; }
            public string MasterColumnThree { get; set; }
            public string MasterColumnFour { get; set; }
            public string PreferencesName { get; set; }
            public bool isDefault { get; set; }
    }
}
