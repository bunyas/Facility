﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ChssStorageCondition
    {
        public int FacilityCode { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int GuidId { get; set; }
        public int? Result { get; set; }
        public string Comment { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual ChssQuestionGuid Guid { get; set; }
    }
}
