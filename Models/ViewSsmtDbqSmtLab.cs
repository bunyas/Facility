﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewSsmtDbqSmtLab
    {
        public int? DistrictCode { get; set; }
        public int? FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime? DateVisit { get; set; }
        public string LabCat1Desc { get; set; }
        public string LabCat2Desc { get; set; }
        public string LabCat3Desc { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? ItemAvialable { get; set; }
        public DateTime? DateIssueVourcher { get; set; }
        public double? QuantityIssuedVourcher { get; set; }
        public DateTime? DateIssueStockCard { get; set; }
        public double? QuantityIssueStockCard { get; set; }
        public int? DateTally { get; set; }
        public int? QuantitiesTally { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
    }
}
