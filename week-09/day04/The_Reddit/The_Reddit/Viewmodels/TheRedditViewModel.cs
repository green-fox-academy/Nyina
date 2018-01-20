using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Reddit.Models;

namespace The_Reddit.Viewmodels
{
    public class TheRedditViewModel
    {
        //A viewhoz kell, az actionben kell használni (mert alapból csak 1 modelt lehet átadni a viewnak és így nem látszik egy viewban a Post és a User modell)
        public List<Post> Post { get; set; }
        public User User { get; set; } 
    }
}
