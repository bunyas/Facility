﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class SsmtASubmittedDoc
    {
        public SsmtASubmittedDoc()
        {
            SsmtSubmittedDocuments = new HashSet<SsmtSubmittedDocuments>();
        }

        public int SubmittedDocCode { get; set; }
        public string SubmittedDoc { get; set; }

        public virtual ICollection<SsmtSubmittedDocuments> SsmtSubmittedDocuments { get; set; }
    }
}
