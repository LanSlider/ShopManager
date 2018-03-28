namespace ShopManager.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreProductMap")]
    public partial class StoreProductMap
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Store Store { get; set; }
    }
}
