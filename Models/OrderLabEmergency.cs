﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class OrderLabEmergency
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ItemCode { get; set; }
        public DateTime DatePrepared { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAdjustment { get; set; }
        public double? ClosingBalance { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? TotalCost { get; set; }
        public string Comments { get; set; }
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
        public string Rfsonotes { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? RecordStatus { get; set; }
        public bool? OnlyConsummableProducts { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AProductLabCategory ItemCodeNavigation { get; set; }
    }
}
