using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewPmpTotalDeliveries
    {
        public DateTime DepartureDate { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? ExpectedDateAtSite { get; set; }
        public DateTime? ActualDateAtSite { get; set; }
    }
}
