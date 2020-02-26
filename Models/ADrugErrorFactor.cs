﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ADrugErrorFactor
    {
        public short ErrorCode { get; set; }
        public string ErrorName { get; set; }
        public double? ErrorFactor { get; set; }
        public double? ErrorWeight { get; set; }
        public string ErrorDesc { get; set; }
    }
}
