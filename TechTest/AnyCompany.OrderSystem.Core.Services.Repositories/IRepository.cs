using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.OrderSystem.Core.Services.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        //void Add(List<T> items);
        //void Update(T item);
        Task Save();
    }
}
