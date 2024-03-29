﻿using System;
using System.Collections.Generic;

namespace Parking.Domain
{
    public partial class PaymentTariff
    {
        public PaymentTariff()
        {
            ParkingRecords = new HashSet<ParkingRecord>();
        }

        public int Id { get; set; }
        public int? ParkingTypeId { get; set; }
        public int? DaysCount { get; set; }
        public decimal? Payment { get; set; }

        public virtual ParkingType? ParkingType { get; set; }
        public virtual ICollection<ParkingRecord> ParkingRecords { get; set; }
    }
}
