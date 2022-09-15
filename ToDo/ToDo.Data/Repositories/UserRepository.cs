using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Data.Repositories
{
    public class UserRepository : GenericRepository<User>,
        IUserRepository
    {
    }
}
