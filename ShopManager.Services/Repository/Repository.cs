using ShopManager.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopManager.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private EntitiesConnection _context;

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _context.Set<T>().FirstOrDefault();
        }

        public T Add(T item)
        {
            return _context.Set<T>().Add(item);
        }

        public T Update(T item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return item;
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            _context.Set<T>().Remove(entity);
        }

        public Repository(EntitiesConnection context)
        {
            if (context == null)
                throw new ArgumentNullException($"{nameof(context)} is null");

            _context = context;
        }
    }
}
