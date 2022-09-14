using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities
{
    public class TeamMember 
    {
        public int? TeamId { get; set; }
        public virtual Team? Team { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
