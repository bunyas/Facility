using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtAJointVisit
    {
        public SsmtAJointVisit()
        {
            SsmtJointVisit = new HashSet<SsmtJointVisit>();
        }

        public int JointVisitCode { get; set; }
        public string JointVisitDesc { get; set; }

        public virtual ICollection<SsmtJointVisit> SsmtJointVisit { get; set; }
    }
}
