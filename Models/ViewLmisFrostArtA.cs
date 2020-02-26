﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisFrostArtA
    {
        public string LevelOfCare { get; set; }
        public string DistrictName { get; set; }
        public int FacilityCode { get; set; }
        public string Facility { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DrugCode { get; set; }
        public string ProductDescription { get; set; }
        public int? DistrictCode { get; set; }
        public double? ClosingBalance { get; set; }
        public double? Soh { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public double? Amc { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
        public DateTime? AmcDate { get; set; }
        public double? QuantityAllocated { get; set; }
        public int? DeliveryZoneCode { get; set; }
    }
}
