using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ShopManager.Entities.Entities;

namespace ShopManager.Mapping
{
    public class StoreMap : Profile
    {
        public StoreMap()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Store, StoreInfo>());
            CreateMap<Store, StoreInfo>();
         }      
    }
}