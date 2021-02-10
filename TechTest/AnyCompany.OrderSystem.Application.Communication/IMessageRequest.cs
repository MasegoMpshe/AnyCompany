
using MediatR;

namespace AnyCompany.OrderSystem.Application.Communication
{
    public interface IMessageRequest<TResponse> : IRequest<TResponse> where TResponse : new()
    {  }
}
