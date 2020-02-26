﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewPalAmcViralLoad
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ProductCode { get; set; }
        public double? Consumption { get; set; }
    }
}
