﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtASsmts
    {
        public SsmtASsmts()
        {
            SsmtFacility = new HashSet<SsmtFacility>();
        }

        public int SsmtsCode { get; set; }
        public string SsmtsDesc { get; set; }

        public virtual ICollection<SsmtFacility> SsmtFacility { get; set; }
    }
}
