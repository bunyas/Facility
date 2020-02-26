using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ADriverStatus
    {
        public ADriverStatus()
        {
            ADriver = new HashSet<ADriver>();
        }

        public int DriverStatusCode { get; set; }
        public string DriverStatusDesc { get; set; }

        public virtual ICollection<ADriver> ADriver { get; set; }
    }
}
