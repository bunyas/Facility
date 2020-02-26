using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleSecuritySystem
    {
        public DistVehicleSecuritySystem()
        {
            DistVehicleInventoryTrackingSecuritySystem = new HashSet<DistVehicleInventoryTrackingSecuritySystem>();
        }

        public int SecuritySystemId { get; set; }
        public string SecuritySystem { get; set; }

        public virtual ICollection<DistVehicleInventoryTrackingSecuritySystem> DistVehicleInventoryTrackingSecuritySystem { get; set; }
    }
}
