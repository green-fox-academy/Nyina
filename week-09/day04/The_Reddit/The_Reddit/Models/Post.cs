using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace The_Reddit.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}
