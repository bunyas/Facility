﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisEmergencyArt
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductNumbering { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public string OpeningBalance { get; set; }
        public string QuantityRecieved { get; set; }
        public string PmtctConsumption { get; set; }
        public string ArtConsumption { get; set; }
        public string LossesAdjustments { get; set; }
        public string ClosingBalance { get; set; }
        public string MonthsStockAtHand { get; set; }
        public string QuantityRequiredCurrentPatients { get; set; }
        public string EstimatedNewArtPatients { get; set; }
        public string EstimatedNewHivPregnant { get; set; }
        public string DrugsRequiredNewPatients { get; set; }
        public string TotalDrugsRequired { get; set; }
        public string Notes { get; set; }
        public string Rfsonotes { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? FinalSubmissionCheck { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public bool? EportedToSap { get; set; }
        public DateTime? FacilityUpdateDate { get; set; }
        public string FacilityUserName { get; set; }
        public string QuantityAllocated { get; set; }
    }
}
