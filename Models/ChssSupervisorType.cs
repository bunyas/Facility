using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssSupervisorType
    {
        public ChssSupervisorType()
        {
            ChssSupervisor = new HashSet<ChssSupervisor>();
        }

        public int SupervisorType { get; set; }
        public string SupervisorDesc { get; set; }

        public virtual ICollection<ChssSupervisor> ChssSupervisor { get; set; }
    }
}
