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
            return View();
        }

        [HttpPost("add")]
        public IActionResult AreThereAnagrams(string givenAnagram, string givenComparedAnagram)
        {
            anagramModel.AnagramWord = givenAnagram;
            anagramModel.ComparedWord = givenComparedAnagram;

            List<char> sortedAnagram = anagramModel.AnagramWord.ToList();
            sortedAnagram.Sort();
            List<char> sortedAnagram2 = anagramModel.ComparedWord.ToList();
            sortedAnagram2.Sort();

            if (!sortedAnagram2.Equals(sortedAnagram))
            {
                return RedirectToAction(anagramResult.NoResult);
            }
            return RedirectToAction(anagramResult.OkResult);
        }
    }
}
