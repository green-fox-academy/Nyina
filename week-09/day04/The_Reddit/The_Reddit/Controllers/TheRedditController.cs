using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Reddit.Models;
using The_Reddit.Repositories;
using The_Reddit.Viewmodels;
using X.PagedList;
using X.PagedList.Mvc;

namespace The_Reddit.Controllers 
{
    [Route("")]
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

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            //theRedditRepository.Login(name);

            if (theRedditRepository.GetUser(name) is null)
            {
                return View("Index");
            }
            if (name.Equals("Nyina"))
            {
                return Redirect("/posts");
            }
            else
            {
                return View("List", theRedditRepository.GetAUsersListItem(name));
                //Session["username"] = name;
                //return Redirect("/posts");
            }
        }


        [HttpGet("/posts")]
        //Ha az Action neve azonos lenne egy másikkal (itt: List), akkor paraméterben 1-nek meg kell adni ""-be a Listet, utána pedig a methodot
        public IActionResult Showlist(int? page)
        {
            //Ha nem lenne lapozó:
            //return View("List", theRedditRepository.ShowList());

            var pageNumber = page ?? 1;
            var list = theRedditRepository.ShowList();
            return View("List", list.ToPagedList(pageNumber, 5));
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

        [HttpGet("/posts/score_add/{id}")]
        public IActionResult AddScore(long id)
        {
            theRedditRepository.AddScore(id);
            return Redirect("/posts");
        }

        [HttpGet("/posts/score_decrease/{id}")]
        public IActionResult DecreaseScore(long id)
        {
            theRedditRepository.DecreaseScore(id);
            return Redirect("/posts");
        }


    }
}
