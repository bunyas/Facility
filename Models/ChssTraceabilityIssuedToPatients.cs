using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssTraceabilityIssuedToPatients
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int GuidId { get; set; }
        public int? Results { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
