using System;
using System.Collections.Generic;

namespace ShopManager.Services.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T item);
        T Update(T item);
        void Delete(int id);
    }
}
