using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManager.Models
{
    public class StoreInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }
    }
}