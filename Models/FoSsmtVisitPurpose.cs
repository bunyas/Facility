using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoSsmtVisitPurpose
    {
        public FoSsmtVisitPurpose()
        {
            FoSsmtSiteTracker = new HashSet<FoSsmtSiteTracker>();
        }

        public int VisitPurposeCode { get; set; }
        public string VisitPurpose { get; set; }

        public virtual ICollection<FoSsmtSiteTracker> FoSsmtSiteTracker { get; set; }
    }
}
