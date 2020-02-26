﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcTrackerTaskNo
    {
        public ProcTrackerTaskNo()
        {
            ProcTracker = new HashSet<ProcTracker>();
        }

        public string TaskOrderNo { get; set; }
        public int? TaskOrderCode { get; set; }

        public virtual ICollection<ProcTracker> ProcTracker { get; set; }
    }
}
