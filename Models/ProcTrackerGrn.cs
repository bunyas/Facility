using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ProcTrackerGrn
    {
        public string GrnNo { get; set; }
        public int SupplierCode { get; set; }
        public string PurchaseOrderNo { get; set; }
        public DateTime? GrnDate { get; set; }
        public int? GrnQuantity { get; set; }
        public DateTime? DateRecieptWarehouse { get; set; }

        public virtual ProcTrackerOrder ProcTrackerOrder { get; set; }
    }
}
