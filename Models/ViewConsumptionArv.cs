using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewConsumptionArv
    {
        public int FacilityCode { get; set; }
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
        public int DrugCode { get; set; }
        public double? PmtctConsumption { get; set; }
        public double? ArtConsumption { get; set; }
    }
}
