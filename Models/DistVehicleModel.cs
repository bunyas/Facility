﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistVehicleModel
    {
        public DistVehicleModel()
        {
            DistVehicleInventory = new HashSet<DistVehicleInventory>();
        }

        public int ModelCode { get; set; }
        public string ModelDesc { get; set; }

        public virtual ICollection<DistVehicleInventory> DistVehicleInventory { get; set; }
    }
}
