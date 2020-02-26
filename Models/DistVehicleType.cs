using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleType
    {
        public DistVehicleType()
        {
            DistAssessmentResultHeader = new HashSet<DistAssessmentResultHeader>();
        }

        public int VehicleTypeCode { get; set; }
        public string VehicleType { get; set; }

        public virtual ICollection<DistAssessmentResultHeader> DistAssessmentResultHeader { get; set; }
    }
}
