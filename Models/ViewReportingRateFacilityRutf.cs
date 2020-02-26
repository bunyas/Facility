﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewReportingRateFacilityRutf
    {
        public int FacilityCode { get; set; }
        public int? FcExpected { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EndMonthName { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public int ProductCategory { get; set; }
        public int? FcReported { get; set; }
        public string Facility { get; set; }
    }
}
