﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleMajorUse
    {
        public DistVehicleMajorUse()
        {
            DistVehicleInventoryTracking = new HashSet<DistVehicleInventoryTracking>();
        }

        public int UsageCode { get; set; }
        public string Usage { get; set; }

        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTracking { get; set; }
    }
}
