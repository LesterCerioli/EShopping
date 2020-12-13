using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class StockInventoryModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public int StockAmount { get; set; }
        public int StockInventory { get; set; }
        public int ProductId { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}