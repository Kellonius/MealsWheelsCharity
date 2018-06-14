using System.Collections.Generic;

namespace Cape_Senior_Center_Inventory_System.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IList<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        void Delete(T entity);
        T Update(T entity);
    }
}
