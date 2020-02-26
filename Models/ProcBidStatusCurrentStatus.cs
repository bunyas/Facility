﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcBidStatusCurrentStatus
    {
        public ProcBidStatusCurrentStatus()
        {
            ProcBidStatusReport = new HashSet<ProcBidStatusReport>();
        }

        public int StatusCode { get; set; }
        public string StatusDesc { get; set; }

        public virtual ICollection<ProcBidStatusReport> ProcBidStatusReport { get; set; }
    }
}
