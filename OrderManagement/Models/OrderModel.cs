using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Models
{
    public class OrderModel
    {
        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Qty { get; set; }

        public Common.Common.OrderStatus OrderStatus { get; set; }
        
        public AddressModel Address { get; set; }
    }
}