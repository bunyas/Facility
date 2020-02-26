using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistDistibutionScheduleMaulStaff
    {
        public int FacilityCode { get; set; }
        public DateTime DepartureDate { get; set; }
        public int CpCode { get; set; }

        public virtual DistDistibutionSchedule DistDistibutionSchedule { get; set; }
    }
}
