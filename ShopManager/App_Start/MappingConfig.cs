using ShopManager.Entities.Entities;
using ShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManager.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Store, StoreInfo>();
                //  .ForMember(dest => dest.)
                config.CreateMap<StoreInfo, Store>();
                config.CreateMap<Product, ProductInfo>();
                config.CreateMap<ProductInfo, Product>();
            });
        }
    }
}