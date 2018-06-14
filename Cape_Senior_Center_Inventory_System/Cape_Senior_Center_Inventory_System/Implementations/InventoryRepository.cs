using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class InventoryRepository : IInventoryRepository
    {
        protected IUnitOfWork unitOfWork;
        public InventoryRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }

        public Inventory GetById()
        {
            throw new NotImplementedException();
        }
    }
}
