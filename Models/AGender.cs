using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class AGender
    {
        public AGender()
        {
            FoSsmtInterviewedPersonnel = new HashSet<FoSsmtInterviewedPersonnel>();
        }

        public int GenderCode { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<FoSsmtInterviewedPersonnel> FoSsmtInterviewedPersonnel { get; set; }
    }
}
