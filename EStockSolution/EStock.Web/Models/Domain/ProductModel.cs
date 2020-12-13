using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public decimal CoastPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int AmountStock { get; set; }
        public int MeasurementUnitId { get; set; }
        public virtual MeasurementUnitModel MeasurementUnit { get; set; }
        public int GroupId { get; set; }
        public virtual ProductGroupModel Group { get; set; }
        public int BrandId { get; set; }
        public virtual ProductBrandModel Brand { get; set; }
        public int ProviderId { get; set; }
        public virtual ProviderModel Provider { get; set; }
        public int StorageLocalId { get; set; }
        public virtual StorageLocalModel StorageLocal { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
    }
}