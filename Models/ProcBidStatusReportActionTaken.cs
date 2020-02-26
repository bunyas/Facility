using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcBidStatusReportActionTaken
    {
        public int ActionId { get; set; }
        public string ProcurementReferenceNumber { get; set; }

        public virtual ProcBidStatusAction Action { get; set; }
    }
}
