﻿using ShopManager.Entities.Entities;
using ShopManager.Models;
using ShopManager.Services.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ShopManager.Controllers
{
    [RoutePrefix("api")]
    public class ProductController : ApiController
    {
        private UnitOfWork _uow = null;

        public ProductController()
        {
            _uow = new UnitOfWork();
        }

        [Route("store")]
        [HttpGet]
        public List<ProductInfo> GetAllProduct(int id)
        {
            var listProductID = _uow.StoreProductRepository.GetAll().ToList().Where(x => x.StoreId == id);
            List<ProductInfo> listProducts = new List<ProductInfo>();
            var listProductInfo = _uow.ProductRepository.GetAll().ToList();
            foreach (var item in listProductID)
            {
                listProducts.Add(AutoMapper.Mapper.Map<Product, ProductInfo>(_uow.ProductRepository.Get(item.ProductId)));
            }
            return listProducts;
        }


        [HttpPost]
        public void CreateProduct([FromBody] ProductInfo productInfo)
        {
            var product = AutoMapper.Mapper.Map<ProductInfo, Product>(productInfo);
            _uow.ProductRepository.Add(product);
            _uow.Commit();
            //Task task = new Task(() => _uow.CommitAsync());          
        }


        /*
        [Route("products")]
        [HttpGet]
        public IHttpActionResult GetProducts([FromUri])
        {

        }

        public ProductController()
        {
            //_productService = ;
        }*/
    }
}
