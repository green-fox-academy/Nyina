using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Reddit.Models;

namespace The_Reddit.Models
{
    public class ModelForMethodsDatas
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Timastamp { get; set; }
        public int Score { get; set; }
        public string UserName { get; set; }
        public bool Vote { get; set; }

    }
}
