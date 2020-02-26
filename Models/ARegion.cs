﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ARegion
    {
        public ARegion()
        {
            ADistrict = new HashSet<ADistrict>();
        }

        public string RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<ADistrict> ADistrict { get; set; }
    }
}
