﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewPmpProcuredProductsMoh
    {
        public int ProductCode { get; set; }
        public bool? ApprovedMohNtg { get; set; }
        public bool? ApprovedWho { get; set; }
        public bool? ApprovedFda { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
    }
}
