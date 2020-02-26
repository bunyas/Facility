using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewPmpEmergencyProcurement
    {
        public DateTime OrderDueDate { get; set; }
        public DateTime? DateArrivalEntebbe { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
        public int? NormalOrEmergencyProcurement { get; set; }
    }
}
