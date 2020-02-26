﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewSsmtDbqVisitPurpose
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DateVisit { get; set; }
        public string VisitPurposeDesc { get; set; }
        public bool? Visited { get; set; }
        public string Comment { get; set; }
    }
}
