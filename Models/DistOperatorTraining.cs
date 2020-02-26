using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class DistOperatorTraining
    {
        public string OperatorId { get; set; }
        public DateTime DateOfTarining { get; set; }
        public string CourseDescription { get; set; }
        public string Result { get; set; }

        public virtual DistOperatorPersonal Operator { get; set; }
    }
}
