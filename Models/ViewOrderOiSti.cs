﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewOrderOiSti
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? ExportedToSap { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public DateTime? DateExpected { get; set; }
        public int ProductCode { get; set; }
        public int? Expr1 { get; set; }
        public DateTime? Expr2 { get; set; }
        public DateTime? Expr3 { get; set; }
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
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public string RfsoApprovedBy { get; set; }
    }
}
