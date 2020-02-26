﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleCondition
    {
        public DistVehicleCondition()
        {
            DistVehicleInventoryTracking = new HashSet<DistVehicleInventoryTracking>();
        }

        public int ConditionCode { get; set; }
        public string Condition { get; set; }

        public virtual ICollection<DistVehicleInventoryTracking> DistVehicleInventoryTracking { get; set; }
    }
}
