﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewCrystalLmisExpiryTrackingArtB
    {
        public int FacilityCode { get; set; }
        public DateTime? DateOfPhysicalCount { get; set; }
        public int ProductCode { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityDispensary { get; set; }
        public double? QuantityStore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Total { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
