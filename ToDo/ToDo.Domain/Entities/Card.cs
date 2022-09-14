using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Common;

namespace ToDo.Domain.Entities
{
    public class Card : Auditable
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Photo { get; set; } = string.Empty;
        public string Link { get; set; } = String.Empty;
        public string File { get; set; } = String.Empty;
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public bool IsPrivate { get; set; } = true;

    }
}
