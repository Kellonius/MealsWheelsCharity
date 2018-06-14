using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Data.Entity;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext DBContext { get; set; }

        public UnitOfWork(DbContext dbContext)
        {
            DBContext = dbContext;
        }
    }
}
