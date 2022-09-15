using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data.Common.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Data.Interfaces
{
    public interface ICardRepository 
        :IGenericRepository<Card>
    {
    }
}
