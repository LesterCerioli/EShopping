using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class ProductOutputModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}