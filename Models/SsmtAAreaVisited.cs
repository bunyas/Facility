using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtAAreaVisited
    {
        public SsmtAAreaVisited()
        {
            SsmtAreaVisited = new HashSet<SsmtAreaVisited>();
        }

        public int AreaId { get; set; }
        public string AreaDesc { get; set; }

        public virtual ICollection<SsmtAreaVisited> SsmtAreaVisited { get; set; }
    }
}
