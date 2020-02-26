﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewXaProduct
    {
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Strength { get; set; }
        public string Packsize { get; set; }
        public int? CartonSizePkt { get; set; }
        public double? CartonWeightKg { get; set; }
        public int? ProductCategory { get; set; }
        public short? BasicUnit { get; set; }
        public bool? ApprovedMohNtg { get; set; }
        public bool? ApprovedWho { get; set; }
        public bool? ApprovedFda { get; set; }
        public int? NdaRegistration { get; set; }
        public string SapCode { get; set; }
        public bool? ConsummableProduct { get; set; }
        public int? ArtProductClassification { get; set; }
        public string NmsCodes { get; set; }
    }
}
