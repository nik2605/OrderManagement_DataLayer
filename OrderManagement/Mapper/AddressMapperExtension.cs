using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;
using OrderManagement.Models;

namespace OrderManagement.Mapper
{
    public static class AddressMapperExtension
    {
        public static AddressModel Map(this AddressEntity model)
        {
            return new AddressModel()
            {
                Street = model.Street,
                Country = model.Country
            };
        }
    }
}