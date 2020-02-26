using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssCategory
    {
        public ChssCategory()
        {
            ChssClassification = new HashSet<ChssClassification>();
        }

        public int CategoryCode { get; set; }
        public string CategoryDesc { get; set; }

        public virtual ICollection<ChssClassification> ChssClassification { get; set; }
    }
}
