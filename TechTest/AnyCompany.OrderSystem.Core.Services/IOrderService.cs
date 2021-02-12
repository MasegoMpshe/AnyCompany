using AnyCompany.OrderSystem.Core.DomainModel;
using System;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Core.Services
{
    public interface IOrderService
    {
        Task<bool>  PlaceOrder(Order order, int customerId);
    }
}
