using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ADrugFormulationCode
    {
        public ADrugFormulationCode()
        {
            ADrugFormulation = new HashSet<ADrugFormulation>();
        }

        public short DrugFormulationCode { get; set; }
        public string DrugFormulationDesc { get; set; }

        public virtual ICollection<ADrugFormulation> ADrugFormulation { get; set; }
    }
}
