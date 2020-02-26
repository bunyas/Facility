﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewXaAmc
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfAmc { get; set; }
        public int ProductCode { get; set; }
        public double? Amc { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool? RecordStatus { get; set; }
    }
}
