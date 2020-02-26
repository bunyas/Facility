using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoComplaintAffectedSites
    {
        public int ERegComplaintCode { get; set; }
        public int FacilityCode { get; set; }

        public virtual FoComplaint ERegComplaintCodeNavigation { get; set; }
        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
