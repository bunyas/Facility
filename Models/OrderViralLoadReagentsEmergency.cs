﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class OrderViralLoadReagentsEmergency
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProductCode { get; set; }
        public DateTime DatePrepared { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? QuantityOrdered { get; set; }
        public string Comment { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public string FacilityUserName { get; set; }
        public DateTime? FacilityUpdateDate { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public bool? EportedToSap { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
    }
}
