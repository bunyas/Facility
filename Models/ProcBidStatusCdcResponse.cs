﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcBidStatusCdcResponse
    {
        public ProcBidStatusCdcResponse()
        {
            ProcBidStatusReport = new HashSet<ProcBidStatusReport>();
        }

        public int ReponseCode { get; set; }
        public string ResponseDesc { get; set; }

        public virtual ICollection<ProcBidStatusReport> ProcBidStatusReport { get; set; }
    }
}
