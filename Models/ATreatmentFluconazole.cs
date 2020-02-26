using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ATreatmentFluconazole
    {
        public ATreatmentFluconazole()
        {
            TreatmentFluconazole = new HashSet<TreatmentFluconazole>();
        }

        public int ConditionCode { get; set; }
        public string Condition { get; set; }

        public virtual ICollection<TreatmentFluconazole> TreatmentFluconazole { get; set; }
    }
}
