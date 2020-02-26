﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class HssBaselineBulkStore
    {
        public int FacilityCode { get; set; }
        public DateTime InterviewDate { get; set; }
        public int SubIndicatorCode { get; set; }
        public int? YesNo { get; set; }
        public string Remarks { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual HssBaselineBulkStoreSubIndicator SubIndicatorCodeNavigation { get; set; }
    }
}
