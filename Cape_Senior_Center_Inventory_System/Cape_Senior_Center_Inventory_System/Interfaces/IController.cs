using Cape_Senior_Center_Inventory_System.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.Interfaces
{
    public interface IController
    {
        List<InventoryModel> InventoryModels { get; set; }
    }
}
