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

        public List<StoreInfo> GetAllStore()
        {
            var listStore = _uow.StoreRepository.GetAll().ToList();
            var listStoreInfo = AutoMapper.Mapper.Map<List<Store>, List<StoreInfo>>(listStore);
            return listStoreInfo;
        }
    }
}
