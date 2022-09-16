using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Service.ViewModels
{
    public class CommentViewModel
    {
        public string Description { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public int? CardId { get; set; }
        public virtual Card? Card { get; set; }
    }
}
