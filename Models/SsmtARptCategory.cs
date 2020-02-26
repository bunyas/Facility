﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtARptCategory
    {
        public SsmtARptCategory()
        {
            SsmtRptIndicator = new HashSet<SsmtRptIndicator>();
        }

        public int RptCategoryId { get; set; }
        public string RptCategoryDesc { get; set; }

        public virtual ICollection<SsmtRptIndicator> SsmtRptIndicator { get; set; }
    }
}
