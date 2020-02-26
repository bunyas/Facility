﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class StockOnHand
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public decimal? OnHand { get; set; }
        public decimal? OnOrder { get; set; }
        public decimal? IsCommited { get; set; }
    }
}
