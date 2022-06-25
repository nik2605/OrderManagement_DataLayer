﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Data.Entity
{
    public class OrderEntity
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Qty { get; set; }

        public string Status { get; set; }
        public int AddressId { get; set; }
        public virtual AddressEntity AddressItem { get; set; }
    }
}