﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewLmisConsumption
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DrugCode { get; set; }
        public double? Consumption { get; set; }
    }
}
