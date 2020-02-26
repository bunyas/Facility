﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssMPharmSolution
    {
        public int FacilityCode { get; set; }
        public string SapCode { get; set; }
        public string Facility { get; set; }
        public int? DistrrictCode { get; set; }
        public string DistrictName { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplimentingPartnerDescription { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplimentingPartnerDescription { get; set; }
        public string Scto { get; set; }
        public int GuidId { get; set; }
        public string Question { get; set; }
        public string Result { get; set; }
        public DateTime DateOfVisit { get; set; }
    }
}
