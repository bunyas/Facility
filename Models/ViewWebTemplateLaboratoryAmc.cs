﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewWebTemplateLaboratoryAmc
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public double? Amc { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool? RecordStatus { get; set; }
        public bool? AmcEqualToZero { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? DateAmc { get; set; }
    }
}
