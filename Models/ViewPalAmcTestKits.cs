﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewPalAmcTestKits
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public double? TestUsed2months { get; set; }
    }
}
