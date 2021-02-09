
using MediatR;

namespace Insurance.Client.Application.Communication
{
    public interface IMessageRequest<TResponse> : IRequest<TResponse> where TResponse : new()
    {  }
}
