using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Reddit.Models;
using The_Reddit.Repositories;
using The_Reddit.Viewmodels;

namespace The_Reddit.Controllers 
{
    public class TheRedditController : Controller
    {
        private TheRedditRepository theRedditRepository;
        //private TheRedditService theRedditService;

        public TheRedditController(TheRedditRepository theRedditRepository) 
            //,TheRedditService theRedditService)
        {
            this.theRedditRepository = theRedditRepository;
            //this.theRedditService = theRedditService;
        }

        [HttpGet("/")]
        //Index action, hogy egyből átdobjon a posts-ra
        public IActionResult Index()
        {
            return Redirect("posts");
        }


        [HttpGet("/posts")]
        //Ha az Action neve azonos lenne egy másikkal (itt: List), akkor paraméterben 1-nek meg kell adni ""-be a Listet, utána pedig a methodot
        public IActionResult Showlist()
        {
            return View("List", theRedditRepository.ShowList());
        }

        [HttpGet("/posts/add")]
        public IActionResult ViewAddForm()
        {
            return View("Add");
        }

        [HttpPost("/posts/add")]
        public IActionResult CreateListElement(Post post, string Name)
        {
            theRedditRepository.CreateANewContent(post, Name);
            return Redirect("/posts");
        }



        [HttpPost("/score_add")]
        public IActionResult AddScore(Post post)
        {
            theRedditRepository.AddScore(post);
            return Redirect("/posts");
        }

        [HttpPost("/score_decrease")]
        public IActionResult DecreaseScore(Post post)
        {
            theRedditRepository.DecreaseScore(post);
            return Redirect("/posts");
        }

    }
}
