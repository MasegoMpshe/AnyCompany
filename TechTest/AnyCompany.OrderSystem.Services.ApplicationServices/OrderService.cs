using AnyCompany.OrderSystem.Core.DomainModel;
using AnyCompany.OrderSystem.Core.Services;
using AnyCompany.OrderSystem.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Services.ApplicationServices
{
    public class OrderService: IOrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public async Task<bool> PlaceOrder(Order order, int customerId)
        {
            Customer customer = CustomerRepository.Load(customerId);

            if (order.Amount == 0)
                return false;

            if (customer.Country == "UK")
                order.VAT = 0.2d;
            else
                order.VAT = 0;

            orderRepository.Add(order);

            return true;
        }


    }
}
