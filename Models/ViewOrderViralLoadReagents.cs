﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewOrderViralLoadReagents
    {
        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
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
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? QuantityOrdered { get; set; }
        public string Comment { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
    }
}
