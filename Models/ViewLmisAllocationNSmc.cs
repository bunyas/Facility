﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisAllocationNSmc
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int ProductCode { get; set; }
        public double? OpeningBalance { get; set; }
        public double? QtyRecieved { get; set; }
        public double? Consumption { get; set; }
        public double? LossesAndAdjustments { get; set; }
        public double? TotalClosingBalance { get; set; }
        public double? QuantityToOrder { get; set; }
        public int? QuantityAllocated { get; set; }
        public string Comments { get; set; }
        public string Rfsonotes { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public bool? EmergencyOrder { get; set; }
        public string Facility { get; set; }
    }
}
