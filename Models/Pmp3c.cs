﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class Pmp3c
    {
        public string CopYear { get; set; }
        public string Period { get; set; }
        public string TaskOrder { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? NormalProcurement { get; set; }
        public double? EmergencyProcurement { get; set; }
        public decimal? TotalCostFobMaulPriceUsd { get; set; }
        public decimal? TotalOrderCostScmsUsd { get; set; }
        public decimal? TotalSavingBasedOnFob { get; set; }
    }
}
