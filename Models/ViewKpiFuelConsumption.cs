﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewKpiFuelConsumption
    {
        public string VehicleRegistration { get; set; }
        public int? SelectedMonth { get; set; }
        public int? SelectedYear { get; set; }
        public DateTime? FirstDay { get; set; }
        public DateTime? LastDay { get; set; }
        public int? FuelAdded { get; set; }
    }
}
