using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssTraceabilitySpecializationClassification
    {
        public ChssTraceabilitySpecializationClassification()
        {
            ChssTraceabilitySpecialisation = new HashSet<ChssTraceabilitySpecialisation>();
        }

        public int ClassificationCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ChssTraceabilitySpecialisation> ChssTraceabilitySpecialisation { get; set; }
    }
}
