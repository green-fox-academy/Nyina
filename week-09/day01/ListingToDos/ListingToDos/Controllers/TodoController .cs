using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListingToDos.Models;
using ListingToDos.Repositories;

namespace ListingToDos.Controllers
{
    [Route("")]
    public class TodoController : Controller
    {
        private ToDoRepository toDoRepository;

        public TodoController (ToDoRepository toDoRepository)
        {
            this.toDoRepository = toDoRepository;
        }

        [HttpGet("/todo")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("/list")]
        //public IActionResult List()
        //{
        //    //A . után be kell hivatkozni a repository listát funkcióját
        //    return View(toDoRepository.ShowList());
        //}

        [Route("/list")]
        public IActionResult List([FromQuery]bool isActive)
        {
            //Paraméterben kell megadni a szűrési feltételt: (active means !isDone): http://localhost:5000/todo/?isActive=true
            //A repositoryban, ahogy a methodokat eddig is csináltuk

            //Itt már a decide methodot használjuk
            return View(toDoRepository.DecideListType(isActive));
        }

        [HttpGet()]

    }
}
