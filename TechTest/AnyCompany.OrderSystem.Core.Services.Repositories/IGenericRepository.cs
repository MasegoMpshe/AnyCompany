using System;
using System.Collections.Generic;
using System.Text;

namespace AnyCompany.OrderSystem.Core.Services.Repositories
{
    public interface IGenericRepository<T> : IReadRepository<T>, IRepository<T>
    {
    }
}
