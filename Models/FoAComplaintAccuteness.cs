﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoAComplaintAccuteness
    {
        public FoAComplaintAccuteness()
        {
            FoComplaint = new HashSet<FoComplaint>();
        }

        public int AccutenessCode { get; set; }
        public string AccutenessDesc { get; set; }

        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
    }
}
