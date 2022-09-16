using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Service.ViewModels
{
    public class CardViewModel 
    {

        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Photo { get; set; } = string.Empty;
        public string Link { get; set; } = String.Empty;
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
