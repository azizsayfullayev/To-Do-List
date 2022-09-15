using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Data.Common.Interfaces
{
    public interface IReadable <T>
    {
        Task<T> ReadAsync(int id);

        
        Task<IEnumerable<T>> ReadAllAsync();
    }
}
