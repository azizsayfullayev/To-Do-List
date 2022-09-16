using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Common;

namespace ToDo.Domain.Entities
{
    public class Desk :BaseEntity
    {
        public string Name { get; set; } = "Template Desk";
        public string Photo { get; set; } = $"ToDo.WPF/Assets/Images/ligh-green.jpg";
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public bool IsPrivate { get; set; } = true;
    }
}
