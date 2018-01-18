using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Reddit.Models;
using The_Reddit.Repositories;
using The_Reddit.Viewmodels;
using The_Reddit.Services;

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
            return Redirect("/posts");
        }


        [HttpGet("/posts")]
        //Ha az Action neve azonos lenne egy másikkal (itt: List), akkor paraméterben 1-nek meg kell adni ""-be a Listet, utána pedig a methodot
        public IActionResult Posts()
        {
            TheRedditService theRedditService = new TheRedditService(theRedditRepository);
            var interesting = theRedditService.ViewDetails();
            return View("List", interesting);
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

        [HttpGet("/posts/add")]
        public IActionResult ViewAddForm()
        {
            return View("Add");
        }

        [HttpPost("/posts/add")]
        public IActionResult CreateListElement(string name, Post PoSt)
        {
            theRedditRepository.CreateNewListItem(name, PoSt);
            return Redirect("/posts");
        }

    }
}
