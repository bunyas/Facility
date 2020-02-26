﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtAVisitPurpose
    {
        public SsmtAVisitPurpose()
        {
            SsmtVisitPurpose = new HashSet<SsmtVisitPurpose>();
        }

        public int VisitPurposeCode { get; set; }
        public string VisitPurposeDesc { get; set; }

        public virtual ICollection<SsmtVisitPurpose> SsmtVisitPurpose { get; set; }
    }
}
