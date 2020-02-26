﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewWebTemplateLaboratoryReportHeader
    {
        public string Facility { get; set; }
        public string DistrictName { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DatePrepared { get; set; }
        public int? OrderTypeId { get; set; }
        public int? OrderStatusId { get; set; }
        public string SapCode { get; set; }
        public string OrderNumber { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }
        public bool? FinalSubmission { get; set; }
    }
}
