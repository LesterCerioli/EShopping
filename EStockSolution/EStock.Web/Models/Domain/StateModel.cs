using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class StateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }
        public bool Active { get; set; }
        public int CountryId { get; set; }
        public virtual CountryModel Country { get; set; }
    }
}