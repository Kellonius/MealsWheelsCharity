using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.Interfaces
{
    public interface IUnitOfWork
    {
        DbContext DBContext { get; set; }
    }
}
