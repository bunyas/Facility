﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssViralLoadOrderView
    {
        public int? FacilityCode { get; set; }
        public string Facility { get; set; }
        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? OpeningBalance { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? Consumption { get; set; }
    }
}
