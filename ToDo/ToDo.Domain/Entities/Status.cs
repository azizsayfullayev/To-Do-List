using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Common;

namespace ToDo.Domain.Entities
{
    public class Status : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
