using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManager.Services.Services.Products.Filters;
using ShopManager.Services.Services.Products.Models;
using ShopManager.Services.UnitOfWork;

namespace ShopManager.Services.Services.Products
{
    class ProductService : IProductService
    {
        IUnitOfWork _uow;
        public List<ProductInfo> GetByFilter(Filter filter)
        {
            var repository = _uow.GetRepository();
        }
    }
}
