using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace The_Reddit.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool Vote { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
