using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssEquipment
    {
        public ChssEquipment()
        {
            ChssEquipmentVerification = new HashSet<ChssEquipmentVerification>();
        }

        public int EquipId { get; set; }
        public int? CatId { get; set; }
        public string EquipDesc { get; set; }

        public virtual ChssEquipmentCategory Cat { get; set; }
        public virtual ICollection<ChssEquipmentVerification> ChssEquipmentVerification { get; set; }
    }
}
