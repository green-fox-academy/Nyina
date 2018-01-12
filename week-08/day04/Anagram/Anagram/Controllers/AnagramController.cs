using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagram.Models; 
using Microsoft.AspNetCore.Mvc;

namespace Anagram.Controllers
{
    [Route("")]
    public class AnagramController : Controller
    {
        private AnagramModel anagramModel;
        private AnagramResult anagramResult;

        public AnagramController(AnagramModel anagramModel, AnagramResult anagramResult)
        {
            this.anagramModel = anagramModel;
            this.anagramResult = anagramResult;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(anagramResult);
        }

        [HttpPost("add")]
        public IActionResult AreThereAnagrams(string givenAnagram, string givenComparedAnagram)
        {
            anagramModel.AnagramWord = givenAnagram;
            anagramModel.ComparedWord = givenComparedAnagram;

            char[] sortedAnagram = anagramModel.AnagramWord.ToArray();
            Array.Sort(sortedAnagram);
            char[] sortedAnagram2 = anagramModel.ComparedWord.ToArray();
            Array.Sort(sortedAnagram2);

            if (sortedAnagram.Length == sortedAnagram2.Length)
            {
                for (int i = 0; i < sortedAnagram2.Length; i++)
                {
                    if (sortedAnagram2[i].Equals(sortedAnagram[i]))
                    {
                        anagramResult.Result = "These words are anagrams.";
                    }
                    else
                    {
                        anagramResult.Result = "These words are not anagrams.";
                    }
                }
            }
            else
            {
                anagramResult.Result = "These words are not anagrams.";
            }
            return RedirectToAction("Index");
        }
    }
}
