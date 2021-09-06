﻿using System;

namespace OrderService.API.Contracts.Outgoing
{
    public class FoundOrderDTO
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public decimal Cost { get; set; }

        public string Username { get; set; }

        public string Product { get; set; }

        public string DeliveryCompany { get; set; }

        public DateTime OrderedAt { get; set; }

        public DateTime DeliveredAt { get; set; }
    }
}
