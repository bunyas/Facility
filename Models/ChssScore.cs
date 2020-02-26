using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssScore
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int? SparsScore { get; set; }
        public int? SparsPlusScore { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
