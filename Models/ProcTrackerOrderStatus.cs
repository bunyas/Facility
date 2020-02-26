﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcTrackerOrderStatus
    {
        public ProcTrackerOrderStatus()
        {
            ProcTrackerProductDetail = new HashSet<ProcTrackerProductDetail>();
        }

        public int OrderStatusId { get; set; }
        public string OrderStatusDesc { get; set; }

        public virtual ICollection<ProcTrackerProductDetail> ProcTrackerProductDetail { get; set; }
    }
}
