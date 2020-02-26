﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class OrderMaultHeader
    {
        public OrderMaultHeader()
        {
            OrderMault = new HashSet<OrderMault>();
        }

        public string OrderNumber { get; set; }
        public int FacilityCode { get; set; }
        public DateTime? DatePrepared { get; set; }
        public DateTime? DateExpected { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool? EmergencyOrder { get; set; }
        public bool? FinalSubmission { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? OrderStatusId { get; set; }
        public string OrderStatusIdChangedBy { get; set; }
        public DateTime? OrderStatusIdDateChanged { get; set; }
        public string FacilityUserName { get; set; }
        public bool? RfsoSentBackTofacility { get; set; }
        public string RfsoSentBackBy { get; set; }
        public DateTime? RfsoSentBackDate { get; set; }
        public bool? RfsoApproveOrder { get; set; }
        public string RfsoApprovedBy { get; set; }
        public DateTime? RfsoDateOfApproval { get; set; }

        public virtual AFacilities FacilityCodeNavigation { get; set; }
        public virtual AOrderStatus OrderStatus { get; set; }
        public virtual AProductCategory ProductCategory { get; set; }
        public virtual ICollection<OrderMault> OrderMault { get; set; }
    }
}
