﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleCheckParticular
    {
        public DistVehicleCheckParticular()
        {
            DistVehicleCheckStatus = new HashSet<DistVehicleCheckStatus>();
        }

        public int ParticularCode { get; set; }
        public string ParticularDesc { get; set; }

        public virtual ICollection<DistVehicleCheckStatus> DistVehicleCheckStatus { get; set; }
    }
}
