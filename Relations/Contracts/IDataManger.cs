using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Contracts
{
    public interface IDataManger<T>
    {
        Task<IEnumerable<T>> GetAllData();
        Task<int> SetData(T entity);
        Task<bool> UpdateData(T entity);


    }
}
