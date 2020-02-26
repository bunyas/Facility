using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtALocation
    {
        public SsmtALocation()
        {
            SsmtPersonnel = new HashSet<SsmtPersonnel>();
        }

        public int LocationId { get; set; }
        public string LocationDesc { get; set; }

        public virtual ICollection<SsmtPersonnel> SsmtPersonnel { get; set; }
    }
}
