using Cape_Senior_Center_Inventory_System.Interfaces;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class InventoryService : IInventoryService
    {
        ICategoryRepository categoryRepository;
        public InventoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
    }
}
