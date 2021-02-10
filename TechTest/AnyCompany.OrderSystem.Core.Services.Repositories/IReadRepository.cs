using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Core.Services.Repositories
{
    public interface IReadRepository<T>
    {
        Task<T> GetByID(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> query);
    }
}
