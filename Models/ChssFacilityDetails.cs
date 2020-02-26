﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssFacilityDetails
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DateTime? NextPlannedVisit { get; set; }
        public int? CcuCode { get; set; }
        public int? VisitNo { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? AdjustedDate { get; set; }
        public string AdjustedBy { get; set; }
        public string Reason { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
