using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities
{
    public class DeskCard
    {
        public int? DeskId { get; set; }
        public virtual Desk? Desk { get; set; }
        public int? CardId { get; set; }
        public virtual Card? Card { get; set; }
    }
}
