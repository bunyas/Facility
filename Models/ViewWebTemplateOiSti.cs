﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewWebTemplateOiSti
    {
        public int ItemNumber { get; set; }
        public string ProductCode { get; set; }
        public string ItemDescription { get; set; }
        public string BasicUnit { get; set; }
        public double? PhysicalCountAtBeginningOfReviewPeriod { get; set; }
        public double? QuantityReceivedDuringTheTwoMonthsCycle { get; set; }
        public double? QuantityUsedDuringTwoMonths { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? NumberOfDaysOutOfStock { get; set; }
        public double? ThisMonthPhysicalCount { get; set; }
        public double? Amc { get; set; }
        public double? MonthsOfStock { get; set; }
        public double? MaximumStockQuantity { get; set; }
        public double? QuantityRequired { get; set; }
        public string Notes { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
