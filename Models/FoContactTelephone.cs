using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoContactTelephone
    {
        public int CpCode { get; set; }
        public int CtTelephone { get; set; }
        public int? CtTelephone2 { get; set; }
        public int? CtTelephone3 { get; set; }

        public virtual FoContactPerson CpCodeNavigation { get; set; }
    }
}
