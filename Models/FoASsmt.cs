using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoASsmt
    {
        public FoASsmt()
        {
            FoSsmtSiteTracker = new HashSet<FoSsmtSiteTracker>();
        }

        public int SsmtCode { get; set; }
        public string SsmtDesc { get; set; }

        public virtual ICollection<FoSsmtSiteTracker> FoSsmtSiteTracker { get; set; }
    }
}
