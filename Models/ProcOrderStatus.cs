﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcOrderStatus
    {
        public ProcOrderStatus()
        {
            ProcTask = new HashSet<ProcTask>();
        }

        public int OrderStatusCode { get; set; }
        public string OrderStatusDesc { get; set; }

        public virtual ICollection<ProcTask> ProcTask { get; set; }
    }
}
