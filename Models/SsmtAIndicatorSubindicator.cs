﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtAIndicatorSubindicator
    {
        public int IndicatorId { get; set; }
        public int SubindicatorId { get; set; }

        public virtual SsmtAIndicator Indicator { get; set; }
        public virtual SsmtASubindicator Subindicator { get; set; }
    }
}
