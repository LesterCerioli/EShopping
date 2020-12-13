using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class ProviderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SocialReason { get; set; }
        public string DocumentNumber { get; set; }
        public KindModel Kind { get; set; }
        public string Telephone { get; set; }
        public string Contact { get; set; }
        public string StreetOrAvenue { get; set; }
        public string Number { get; set; }
        public string Additional { get; set; }
        public string PostalCode { get; set; }
        public int CoutryId { get; set; }
        public virtual CountryModel Country { get; set; }
        public int StateId { get; set; }
        public virtual StateModel State { get; set; }
        public int CityId { get; set; }
        public virtual CityModel City { get; set; }
        public bool Active { get; set; }
    }
}