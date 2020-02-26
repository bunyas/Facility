using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcBidStatusReportProcurementMethod
    {
        public ProcBidStatusReportProcurementMethod()
        {
            ProcBidStatusReport = new HashSet<ProcBidStatusReport>();
        }

        public int ProcMethodCode { get; set; }
        public string ProcMethodDesc { get; set; }

        public virtual ICollection<ProcBidStatusReport> ProcBidStatusReport { get; set; }
    }
}
