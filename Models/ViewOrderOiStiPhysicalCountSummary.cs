﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewOrderOiStiPhysicalCountSummary
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfPhysicalCount { get; set; }
        public int ProductCode { get; set; }
        public double ClosingBalance { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
