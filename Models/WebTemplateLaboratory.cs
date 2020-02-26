﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class WebTemplateLaboratory
    {
        public int ProductOrder { get; set; }
        public int? ProductCode { get; set; }
        public int? OriginalProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string BasicUnit { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsVisible { get; set; }
    }
}
