using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Models
{
    public class AnagramResult
    {
        public string OkResult { get; set; } = "These words are anagrams.";
        public string NoResult { get; set; } = "These words are not anagrams.";
    }
}
