using AnyCompany.OrderSystem.Application.Communication;
using AnyCompany.OrderSystem.Application.Tasks.Command;
using AnyCompany.OrderSystem.Core.DomainModel;
using AnyCompany.OrderSystem.Core.DomainModel.ResponseDTO;
using AnyCompany.OrderSystem.Core.Services;
using AnyCompany.OrderSystem.Core.Services.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Services.EventHandlers.Command
{
    public class CreateOrderCommandHandler : IMessageRequestHandler<CreateOrderCommand, bool>
    {            
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public CreateOrderCommandHandler(IMapper mapper, IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            return await _orderService.PlaceOrder(_mapper.Map<Order>(request.CommandData), request.CommandData.CustomerId);
        }


    }
}
