﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewSsmtDbqPersonnel
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime? DateVisit { get; set; }
        public string PersonnelName { get; set; }
        public string PersonnelDesc { get; set; }
        public string LocationDesc { get; set; }
        public int? GenderId { get; set; }
        public string TitleDesc { get; set; }
        public int? Telephone { get; set; }
        public string Email { get; set; }
    }
}
