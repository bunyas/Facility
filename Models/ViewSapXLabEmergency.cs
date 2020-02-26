﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewSapXLabEmergency
    {
        public bool? MiCheck { get; set; }
        public int? LevelOfCare { get; set; }
        public string Facility { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSapCode { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string Packsize { get; set; }
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DatePrepared { get; set; }
        public int? QuantityAllocated { get; set; }
        public double? Consumption { get; set; }
        public string FacilitySapCode { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
