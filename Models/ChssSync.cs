﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssSync
    {
        public int Facilitycode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DateTime? SyncDate { get; set; }

        public virtual AFacilities FacilitycodeNavigation { get; set; }
    }
}
