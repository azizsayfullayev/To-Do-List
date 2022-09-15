using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data.Common.Interfaces;

namespace ToDo.Data.Interfaces
{
    public interface IGenericRepository<T>
    : ICreateable<T>, IReadable<T>,
    IUpdateable<T>, IDeleteable<T> where T : class
    {

    }
}
