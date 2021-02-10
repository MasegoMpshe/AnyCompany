using AnyCompany.OrderSystem.Application.Communication;
using AnyCompany.OrderSystem.Application.Tasks.Command;
using AnyCompany.OrderSystem.Core.DomainModel;
using AnyCompany.OrderSystem.Core.DomainModel.ResponseDTO;
using AnyCompany.OrderSystem.Core.Services.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Services.EventHandlers.Command
{
    public class CreateOrderCommandHandler : IMessageRequestHandler<CreateOrderCommand, OrderResponse>
    {
            
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public Task<OrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
