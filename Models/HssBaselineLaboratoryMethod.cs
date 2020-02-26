using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class HssBaselineLaboratoryMethod
    {
        public HssBaselineLaboratoryMethod()
        {
            HssBaselineLaboratoryAssessmentQuestion = new HashSet<HssBaselineLaboratoryAssessmentQuestion>();
        }

        public int LaboratoryMethodCode { get; set; }
        public string LaboratoryMethodDesc { get; set; }

        public virtual ICollection<HssBaselineLaboratoryAssessmentQuestion> HssBaselineLaboratoryAssessmentQuestion { get; set; }
    }
}
