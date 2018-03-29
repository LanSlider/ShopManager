using ShopManager.Entities.Entities;
using ShopManager.Models;
using ShopManager.Services.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopManager.Controllers
{
    [RoutePrefix("api")]
    public class StoreController : ApiController
    {
        private UnitOfWork _uow = null;

        public StoreController()
        {
            _uow = new UnitOfWork();
        }

        [Route("store")]
        [HttpGet]
        public List<StoreInfo> GetAllStore()
        {
            var listStore = _uow.StoreRepository.GetAll().ToList();
            var listStoreInfo = AutoMapper.Mapper.Map<List<Store>, List<StoreInfo>>(listStore);
            return listStoreInfo;
        }

        
        [HttpGet]
        public IEnumerable<ProductInfo> GetAllProduct([FromUri]int id)
        {
            
            var listProductID = _uow.StoreProductRepository.GetAll().Where(x => x.StoreId == id).ToList();
            List<ProductInfo> listProducts = new List<ProductInfo>();
            var listProductInfo = _uow.ProductRepository.GetAll().ToList();
            foreach (var item in listProductID)
            {
                foreach (var product in listProductInfo)
                {
                    if (product.Id == item.ProductId)
                    {
                        listProducts.Add(AutoMapper.Mapper.Map<Product, ProductInfo>(product));
                    }
                }
            }
            return listProducts;
        }
    }
}
