﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ASupplierStatus
    {
        public ASupplierStatus()
        {
            ASupplier = new HashSet<ASupplier>();
        }

        public int StatusCode { get; set; }
        public string StatusDesc { get; set; }

        public virtual ICollection<ASupplier> ASupplier { get; set; }
    }
}
