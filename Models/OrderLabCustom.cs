﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class OrderLabCustom
    {
        public string OrderNumber { get; set; }
        public int ProductCode { get; set; }
        public double? QuantityRequired { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string Notes { get; set; }

        public virtual OrderLabCustomHeader OrderNumberNavigation { get; set; }
        public virtual AProduct ProductCodeNavigation { get; set; }
    }
}
