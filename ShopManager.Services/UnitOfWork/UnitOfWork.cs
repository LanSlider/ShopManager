using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManager.Entities.Entities;
using ShopManager.Services.Repository;

namespace ShopManager.Services.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        EntitiesConnection _db;
        IRepository<Product> _productRepository;
        IRepository<Store> _storeRepository;

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new Repository<Product>(_db);
                return _productRepository;
            }
        }

        public IRepository<Store> StoreRepository
        {
            get
            {
                if (_storeRepository == null)
                    _storeRepository = new Repository<Store>(_db);
                return _storeRepository;
            }
        }

        public UnitOfWork()
        {
            _db = new EntitiesConnection();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
