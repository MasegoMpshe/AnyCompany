using AnyCompany.OrderSystem.Core.DomainModel.RequestDTO;
using AnyCompany.OrderSystem.Core.DomainModel.ResponseDTO;
using Insurance.Client.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyCompany.OrderSystem.Application.Tasks.Command
{
    public class CreateOrderCommand :ICommand<CreateOrderRequest, OrderResponse>
    {
        public CreateOrderRequest CommandData { get; set; }
    }
}
