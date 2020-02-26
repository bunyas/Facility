using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class HssBaselineBulkStoreIndicators
    {
        public HssBaselineBulkStoreIndicators()
        {
            HssBaselineBulkStoreSubIndicator = new HashSet<HssBaselineBulkStoreSubIndicator>();
        }

        public int IndicatorCode { get; set; }
        public string IndicatorDesc { get; set; }

        public virtual ICollection<HssBaselineBulkStoreSubIndicator> HssBaselineBulkStoreSubIndicator { get; set; }
    }
}
