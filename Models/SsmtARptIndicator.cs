﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtARptIndicator
    {
        public SsmtARptIndicator()
        {
            SsmtRptIndicator = new HashSet<SsmtRptIndicator>();
        }

        public int RptIndicatorId { get; set; }
        public string RptIndicatorDesc { get; set; }

        public virtual ICollection<SsmtRptIndicator> SsmtRptIndicator { get; set; }
    }
}
