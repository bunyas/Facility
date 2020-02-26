﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewExportAtomicHivTkSummary
    {
        public string OrderNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DatePrepared { get; set; }
        public bool? FinalSubmission { get; set; }
        public bool? EmergencyOrder { get; set; }
        public int? OrderTypeId { get; set; }
        public string OrderType { get; set; }
        public int? OrderStatusId { get; set; }
        public string Status { get; set; }
        public int? FacilityCode { get; set; }
        public string Facility { get; set; }
        public int? DeliveryZoneCode { get; set; }
        public string ZoneDescription { get; set; }
        public int? ImplimentingPartnerCode { get; set; }
        public string ImplementingPartnerDescription { get; set; }
        public int? DistrrictCode { get; set; }
        public string District { get; set; }
        public string SapCode { get; set; }
        public bool? SupportedByMaul { get; set; }
        public bool? IsAccredited { get; set; }
        public int? LevelOfCare { get; set; }
        public string LevelDesc { get; set; }
        public int? ClientTypeCode { get; set; }
        public string ClientTypeDesc { get; set; }
        public int? OwnershipId { get; set; }
        public string OwnershipDescription { get; set; }
        public int? CdcregionId { get; set; }
        public string Cdcregion { get; set; }
        public string FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public int? ComprehensiveImplimentingPartnerCode { get; set; }
        public string ComprehensiveImplementingPartnerDescription { get; set; }
        public int? PatientLoadCode { get; set; }
        public string PatientLoadDescription { get; set; }
        public string Scto { get; set; }
        public bool? IsActive { get; set; }
        public int ItemCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? ProductCategory { get; set; }
        public string CategoryDesc { get; set; }
        public string ProductSapCode { get; set; }
        public double? Hct { get; set; }
        public double? Pmtct { get; set; }
        public double? ClinicalDiagnosis { get; set; }
        public double? Smc { get; set; }
        public double? QualityControl { get; set; }
    }
}
