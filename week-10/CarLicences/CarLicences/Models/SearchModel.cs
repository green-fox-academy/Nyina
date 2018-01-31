using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarLicences.Models
{
    public class SearchModel
    {
        [MaxLength(7)]
        public string SearchedItem { get; set; }
        public int Police { get; set; }
        public int Diplomat { get; set; }
    }
}
