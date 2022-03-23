using System.Collections.Generic;

namespace InventoryManagement.Domain.Common
{
    public interface ICrudRepository<T> where T : IAggregateRoot
    {
        IEnumerable<T> List();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
