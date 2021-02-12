using System;
using System.Collections.Generic;
using System.Text;

namespace AnyCompany.OrderSystem.Core.DomainModel.RequestDTO
{
    public class CreateOrderRequest
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public double VAT { get; set; }
        public int CustomerId { get; set; }
    }
}
