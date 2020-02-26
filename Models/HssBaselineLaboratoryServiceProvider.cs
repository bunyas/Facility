using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class HssBaselineLaboratoryServiceProvider
    {
        public HssBaselineLaboratoryServiceProvider()
        {
            HssBaselineLaboratoryMachines = new HashSet<HssBaselineLaboratoryMachines>();
        }

        public int ServiceProviderCode { get; set; }
        public string ServiceProviderDesc { get; set; }

        public virtual ICollection<HssBaselineLaboratoryMachines> HssBaselineLaboratoryMachines { get; set; }
    }
}
