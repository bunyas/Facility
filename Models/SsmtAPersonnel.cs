﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtAPersonnel
    {
        public SsmtAPersonnel()
        {
            SsmtPersonnel = new HashSet<SsmtPersonnel>();
        }

        public int PersonnelId { get; set; }
        public string PersonnelDesc { get; set; }

        public virtual ICollection<SsmtPersonnel> SsmtPersonnel { get; set; }
    }
}
