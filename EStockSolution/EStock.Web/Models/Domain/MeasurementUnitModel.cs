﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EStock.Web.Models.Domain
{
    public class MeasurementUnitModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Initial { get; set; }
        public bool Active { get; set; }
    }
}