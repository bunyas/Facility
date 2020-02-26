﻿using System;
using System.Collections.Generic;

namespace SyncfusionASPNETCoreApplication2.Models
{
    public partial class ViewDistKpiA
    {
        public int? VehicleClassificationId { get; set; }
        public string VehicleClassification { get; set; }
        public int? CopYear { get; set; }
        public int QuarterId { get; set; }
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string VehicleRegistration { get; set; }
        public int? OrdometerStart { get; set; }
        public int? OrdometerEnd { get; set; }
        public int? FuelAdded { get; set; }
        public int? AverageFuelPrice { get; set; }
        public int? DaysWorked { get; set; }
        public int? MaintenanceCost { get; set; }
        public int? DaysInWorkshop { get; set; }
        public int? WorkingDaysMonth { get; set; }
        public int? NoIncidents { get; set; }
        public string KpiKilometersTravelled { get; set; }
        public string KpiFuelConsumption { get; set; }
        public string KpiRunningCostPerKm { get; set; }
        public string KpiAvialability { get; set; }
        public string KpiUtilization { get; set; }
    }
}
