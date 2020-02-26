using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoSsmtArea
    {
        public FoSsmtArea()
        {
            FoSsmtAreaVisited = new HashSet<FoSsmtAreaVisited>();
        }

        public int AreaCode { get; set; }
        public string AreaDesc { get; set; }

        public virtual ICollection<FoSsmtAreaVisited> FoSsmtAreaVisited { get; set; }
    }
}
