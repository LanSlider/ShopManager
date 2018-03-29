using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManager.Entities.Entities;
using ShopManager.Services.Repository;

namespace ShopManager.Services.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        EntitiesConnection _db;
        IRepository<Product> _productRepository;
        IRepository<Store> _storeRepository;
        IRepository<StoreProductMap> _storeProductRepository;

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

        public IRepository<StoreProductMap> StoreProductRepository
        {
            get
            {
                if (_storeProductRepository == null)
                    _storeProductRepository = new Repository<StoreProductMap>(_db);
                return _storeProductRepository;
            }
        }

        public UnitOfWork()
        {
            _db = new EntitiesConnection();
        }

        public void Dispose()
        {
            _db.Dispose();
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
