﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ASectorChange
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfChange { get; set; }
        public int OldSector { get; set; }
        public int? NewSector { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
