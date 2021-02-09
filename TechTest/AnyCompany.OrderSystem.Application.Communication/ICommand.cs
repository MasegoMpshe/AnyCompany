using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Client.Application.Communication
{
    public interface ICommand<TRequest, TResponse> : IMessageRequest<TResponse> where TResponse : new()
    {
        TRequest CommandData { get; set; }
    }
}
