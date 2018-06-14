using Cape_Senior_Center_Inventory_System.DTOs;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class Controller : IController
    {
        IInventoryService inventoryService;
        public List<InventoryModel> InventoryModels { get; set; }
        public Controller(IInventoryService inventoryService)
        {
            this.inventoryService = inventoryService;
            //this.InventoryModels = new List<InventoryModel> { new InventoryModel() { Id = 1, inventoryId = "Bread", inventoryName = "Bunny", quantity = "042543262" },
            //                                                new InventoryModel() { Id = 2, inventoryId = "Chicken Breast", inventoryName = "Tyson", quantity = "9836563658"},
            //                                                new InventoryModel() { Id = 3, inventoryId = "Green Beans", inventoryName = "Green Giant", quantity = "087432762"}};

        }
    }
}
