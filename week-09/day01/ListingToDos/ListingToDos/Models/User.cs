using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //mert 1 usernek több todo-ja is lehet
        public ICollection<ToDo> Todos { get; set; } = new List<ToDo>();
    }
}
