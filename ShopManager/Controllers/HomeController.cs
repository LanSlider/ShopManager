using ShopManager.Entities.Entities;
using ShopManager.Models;
using ShopManager.Services.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopManager.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork _uow = null;

        public HomeController()
        {
            _uow = new UnitOfWork();
        }

        public List<StoreInfo> GetAllStore()
        {
            var listStore = _uow.StoreRepository.GetAll().ToList();
            var listStoreInfo = AutoMapper.Mapper.Map<List<Store>, List<StoreInfo>>(listStore);
            return listStoreInfo;
        }

        public ActionResult Index()
        {
            var listStore = GetAllStore();
            Redirect("/");
            return View(listStore);
        }
    }
}