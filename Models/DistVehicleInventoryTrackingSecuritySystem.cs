using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleInventoryTrackingSecuritySystem
    {
        public string Registration { get; set; }
        public DateTime DateOfInventory { get; set; }
        public int SecuritySystemId { get; set; }

        public virtual DistVehicleInventoryTracking DistVehicleInventoryTracking { get; set; }
        public virtual DistVehicleSecuritySystem SecuritySystem { get; set; }
    }
}
