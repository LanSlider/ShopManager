using ShopManager.Services.Services.Products;
using ShopManager.Services.Services.Products.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopManager.Controllers
{
    [RoutePrefix("api")]
    public class ProductController : ApiController
    {
        IProductService _productService;

        [Route("products")]
        [HttpGet]
        public IHttpActionResult GetProducts([FromUri]Filter filter)
        {

        }

        public ProductController()
        {
            //_productService = ;
        }
    }
}
