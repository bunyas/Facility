﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcTrackerQuarter
    {
        public ProcTrackerQuarter()
        {
            ProcTrackerPurchaseOrderNo = new HashSet<ProcTrackerPurchaseOrderNo>();
        }

        public int QuarterCode { get; set; }
        public string QuarterDesc { get; set; }

        public virtual ICollection<ProcTrackerPurchaseOrderNo> ProcTrackerPurchaseOrderNo { get; set; }
    }
}
