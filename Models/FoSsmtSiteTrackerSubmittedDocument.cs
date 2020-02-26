﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoSsmtSiteTrackerSubmittedDocument
    {
        public DateTime DateOfVisit { get; set; }
        public int FacilityCode { get; set; }
        public int SubmittedDocument { get; set; }

        public virtual FoSsmtSiteTracker FoSsmtSiteTracker { get; set; }
    }
}
