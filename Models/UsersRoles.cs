﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class UsersRoles
    {
        public UsersRoles()
        {
            UsersUserRoles = new HashSet<UsersUserRoles>();
        }

        public int UserRoleCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UsersUserRoles> UsersUserRoles { get; set; }
    }
}
