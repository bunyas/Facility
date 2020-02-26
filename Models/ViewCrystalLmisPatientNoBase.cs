﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewCrystalLmisPatientNoBase
    {
        public int? DeliveryZoneCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SummaryYear { get; set; }
        public int? SummaryMonth { get; set; }
        public short RegimenCode { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? TotalPatients { get; set; }
        public string Facility { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public string DistrictName { get; set; }
        public string RegimenDesc { get; set; }
    }
}
