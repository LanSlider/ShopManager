using ShopManager.Entities.Entities;
using ShopManager.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Services.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<Store> StoreRepository { get; }
        IRepository<StoreProductMap> StoreProductRepository { get; }

        void Commit();
        Task CommitAsync();
    }
}
