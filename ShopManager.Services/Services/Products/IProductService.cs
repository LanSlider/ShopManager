using ShopManager.Services.Services.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Services.Services.Products
{
    public interface IProductService
    {
        List<ProductInfo> GetByFilter(Filters.Filter filter);
    }
}
