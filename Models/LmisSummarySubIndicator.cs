﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class LmisSummarySubIndicator
    {
        public int SubIndicatorCode { get; set; }
        public int? IndicatorCode { get; set; }
        public string SubIndicatorDesc { get; set; }

        public virtual LmisSummaryIndicator IndicatorCodeNavigation { get; set; }
    }
}
