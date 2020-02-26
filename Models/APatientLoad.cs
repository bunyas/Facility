﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class APatientLoad
    {
        public APatientLoad()
        {
            AFacilities = new HashSet<AFacilities>();
        }

        public int PatientLoadCode { get; set; }
        public string PatientLoadDescription { get; set; }

        public virtual ICollection<AFacilities> AFacilities { get; set; }
    }
}
