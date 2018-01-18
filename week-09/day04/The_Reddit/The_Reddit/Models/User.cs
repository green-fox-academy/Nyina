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
        public long UserId { get; set; }
        public string Name { get; set; }
        //mert 1 usernek több post-ja is lehet
        public ICollection<Post> PoSts { get; set; } = new List<Post>();
    }
}
