﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SapSmcSlmSiteOrderDocumetLines
    {
        public int FacilityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int ItemCode { get; set; }
        public bool? CurrentRecord { get; set; }
        public bool? RecordReadBySap { get; set; }
        public string DocNum { get; set; }
        public int? QuantityAllocated { get; set; }
        public int? QuantityOrdered { get; set; }
        public bool? CurrentRecordOnSap { get; set; }

        public virtual SapSmcSlmSiteOrderHeader SapSmcSlmSiteOrderHeader { get; set; }
    }
}
