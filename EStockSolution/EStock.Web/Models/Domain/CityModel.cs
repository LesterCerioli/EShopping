using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int StateId { get; set; }
        public virtual StateModel States { get; set; }
    }
}