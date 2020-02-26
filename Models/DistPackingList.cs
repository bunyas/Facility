﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistPackingList
    {
        public int FacilityCode { get; set; }
        public DateTime PostingDate { get; set; }
        public int DrugCode { get; set; }
        public string BatchNo { get; set; }
        public double? Quantity { get; set; }
        public double? LsatPurchasePrice { get; set; }
        public string Currency { get; set; }
        public double? Price { get; set; }
        public double? LineTotal { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
