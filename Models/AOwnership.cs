﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class AOwnership
    {
        public AOwnership()
        {
            AFacilities = new HashSet<AFacilities>();
        }

        public int OwnershipId { get; set; }
        public string OwnershipDescription { get; set; }

        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
