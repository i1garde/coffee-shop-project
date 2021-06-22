using System.Collections.Generic;
using System.Linq;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class GenericRepository<T, K> : IGenericRepository<T, K> where T : BaseEntity<K>
    {
        protected CoffeeShopDBContext _context;
        
        public GenericRepository(CoffeeShopDBContext context)
        {
            this._context = context;
        }
        
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public T Get(K id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            T find = this.Get(entity.Id);
            _context.Entry(find).CurrentValues.SetValues(entity);
        }

        public void Delete(K id)
        {
            _context.Set<T>().Remove(this.Get(id));
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}