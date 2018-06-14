using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Data.Entity;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public DataContext.DataContext DataContext { get; set; }

        public UnitOfWork(DataContext.DataContext dataContext)
        {
            this.DataContext = dataContext;
        }
    }
}
