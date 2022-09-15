using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities
{
    public class StatusCard 
    {
        public int? StatusId { get; set; }
        public virtual Status? Status { get; set; }
        public int CardId { get; set; }
        public virtual Card? Card { get; set; }
    }
}
