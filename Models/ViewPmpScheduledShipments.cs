using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewPmpScheduledShipments
    {
        public DateTime OrderDueDate { get; set; }
        public DateTime? DateArrivalEntebbe { get; set; }
        public int? ArrivalDays { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
    }
}
