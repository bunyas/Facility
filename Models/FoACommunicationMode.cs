using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoACommunicationMode
    {
        public FoACommunicationMode()
        {
            FoComplaint = new HashSet<FoComplaint>();
        }

        public int CommModeCode { get; set; }
        public string CommModeDesc { get; set; }

        public virtual ICollection<FoComplaint> FoComplaint { get; set; }
    }
}
