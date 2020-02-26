﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class HssBaselineFocusGroupDiscussionMethod
    {
        public HssBaselineFocusGroupDiscussionMethod()
        {
            HssBaselineFocusGroupDiscussionSubIndicator = new HashSet<HssBaselineFocusGroupDiscussionSubIndicator>();
        }

        public int MethodCode { get; set; }
        public string MethodDesc { get; set; }

        public virtual ICollection<HssBaselineFocusGroupDiscussionSubIndicator> HssBaselineFocusGroupDiscussionSubIndicator { get; set; }
    }
}
