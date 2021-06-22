using System.Collections.Generic;

namespace CoffeeShop.DAL.Abstract
{
    public interface IGenericRepository<T, K>
    {
        void Add(T entity);
        T Get(K id);
        void Update(T entity);
        void Delete(K id);
        List<T> GetAll();
    }
}