﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class LmisSummaryCategory
    {
        public LmisSummaryCategory()
        {
            LmisSummaryIndicator = new HashSet<LmisSummaryIndicator>();
        }

        public int CategoryCode { get; set; }
        public string Category { get; set; }

        public virtual ICollection<LmisSummaryIndicator> LmisSummaryIndicator { get; set; }
    }
}
