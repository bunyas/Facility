﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisAllocationNArvSumEmergency
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DrugCode { get; set; }
        public double? QuantityAllocated { get; set; }
        public double? DaysOutOfStockDuring2Months { get; set; }
        public double? AdjustedAmc { get; set; }
        public double? ArtEMtctConsumption { get; set; }
    }
}
