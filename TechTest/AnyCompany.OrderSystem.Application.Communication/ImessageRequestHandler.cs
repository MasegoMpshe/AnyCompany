
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyCompany.OrderSystem.Application.Communication
{
    public interface IMessageRequestHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TResponse : new()
    where TCommand : IMessageRequest<TResponse>
    { }
}
