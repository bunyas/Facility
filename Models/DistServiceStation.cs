using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistServiceStation
    {
        public DistServiceStation()
        {
            DistVehicleMaintaince = new HashSet<DistVehicleMaintaince>();
        }

        public int StationCode { get; set; }
        public string SeviceStation { get; set; }

        public virtual ICollection<DistVehicleMaintaince> DistVehicleMaintaince { get; set; }
    }
}
