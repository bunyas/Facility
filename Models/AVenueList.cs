﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class AVenueList
    {
        public int VenueId { get; set; }
        public int Id { get; set; }
        public string VenueListName { get; set; }

        public virtual AVenue IdNavigation { get; set; }
    }
}
