using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
    }
}