﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisAllocationNArvEmergency
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DrugCode { get; set; }
        public DateTime DatePrepared { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
        public double? LossesAdjustments { get; set; }
        public double? ClosingBalance { get; set; }
        public double? MonthsStockAtHand { get; set; }
        public double? QuantityRequiredCurrentPatients { get; set; }
        public double? EstimatedNewArtPatients { get; set; }
        public double? EstimatedNewHivPregnant { get; set; }
        public double? DrugsRequiredNewPatients { get; set; }
        public double? TotalDrugsRequired { get; set; }
        public string Notes { get; set; }
        public double? QuantityAllocated { get; set; }
        public string Rfsonotes { get; set; }
        public double? DaysOutOfStockDuring2Months { get; set; }
        public double? AdjustedAmc { get; set; }
        public double? ArtEMtctConsumption { get; set; }
    }
}
