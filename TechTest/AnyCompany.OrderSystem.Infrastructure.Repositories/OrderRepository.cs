using AnyCompany.OrderSystem.Core.DomainModel;
using AnyCompany.OrderSystem.Core.Services.Repositories;
using AnyCompany.OrderSystem.Core.Services.Repositories.Command;
using Nest;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Infrastructure.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private static string ConnectionString = @"Data Source=(local);Database=Orders;User Id=admin;Password=password;";

        public void Add(Order item)
        {
            throw new System.NotImplementedException();
        }

       

        public Task Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
