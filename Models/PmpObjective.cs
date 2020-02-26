using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class PmpObjective
    {
        public PmpObjective()
        {
            PmpPerformanceIndicator = new HashSet<PmpPerformanceIndicator>();
        }

        public int PmpObjectiveCode { get; set; }
        public string PmpObjectiveDesc { get; set; }

        public virtual ICollection<PmpPerformanceIndicator> PmpPerformanceIndicator { get; set; }
    }
}
