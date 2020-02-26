﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisFrostHtk
    {
        public string LevelOfCare { get; set; }
        public string DistrictName { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ItemCode { get; set; }
        public string ProductDescription { get; set; }
        public int? DistrictCode { get; set; }
        public double? TestRemaining { get; set; }
        public double? Soh { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public double? Amc { get; set; }
        public double? TestUsed2months { get; set; }
        public DateTime? AmcDate { get; set; }
        public string StockStatus { get; set; }
        public string RecommendedStockMovement { get; set; }
        public double? QuantityToLend { get; set; }
        public double? QuantityToBorrow { get; set; }
        public int? QuantityAllocated { get; set; }
        public int? DeliveryZoneCode { get; set; }
    }
}