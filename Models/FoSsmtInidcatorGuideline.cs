using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class FoSsmtInidcatorGuideline
    {
        public int IndicatorGuidelineCode { get; set; }
        public int? IndicatorCode { get; set; }
        public string IndicatorGuidelineDesc { get; set; }

        public virtual FoSsmtIndicator IndicatorCodeNavigation { get; set; }
    }
}
