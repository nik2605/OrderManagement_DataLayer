using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;
using OrderManagement.Models;

namespace OrderManagement.Mapper
{
    public static class OrderMapperExtension
    {
        public static OrderModel Map(this OrderEntity model)
        {
            return new OrderModel()
            {
                OrderNumber = model.OrderNumber,
                Qty = model.Qty,
                Name = model.Name,
                OrderStatus = (Common.Common.OrderStatus)Enum.Parse(typeof(Common.Common.OrderStatus), model.Status),
                Address = model.AddressItem.Map()
            };
        }
    }
}