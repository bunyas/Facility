using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ADrugRegimenCategory
    {
        public ADrugRegimenCategory()
        {
            ADrugRegimen = new HashSet<ADrugRegimen>();
        }

        public short RegimenCategoryCode { get; set; }
        public string RegimenCategoryDesc { get; set; }

        public virtual ICollection<ADrugRegimen> ADrugRegimen { get; set; }
    }
}
