using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class AProductStatus
    {
        public AProductStatus()
        {
            AProduct = new HashSet<AProduct>();
        }

        public int ProductStatusId { get; set; }
        public string ProductStatus { get; set; }

        public virtual ICollection<AProduct> AProduct { get; set; }
    }
}
