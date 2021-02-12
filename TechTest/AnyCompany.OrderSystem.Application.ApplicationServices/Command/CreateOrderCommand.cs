using AnyCompany.OrderSystem.Application.Communication;
using AnyCompany.OrderSystem.Core.DomainModel.RequestDTO;
using AnyCompany.OrderSystem.Core.DomainModel.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyCompany.OrderSystem.Application.Tasks.Command
{
    public class CreateOrderCommand :ICommand<CreateOrderRequest, bool>
    {
        public CreateOrderRequest CommandData { get; set; }
    }
}
