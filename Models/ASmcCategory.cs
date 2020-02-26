using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ASmcCategory
    {
        public ASmcCategory()
        {
            ASmcItem = new HashSet<ASmcItem>();
        }

        public int CategoryCode { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<ASmcItem> ASmcItem { get; set; }
    }
}
