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
        //Ha az Action neve azonos lenne egy másikkal (itt: List), akkor paraméterben 1-nek meg kell adni ""-be a Listet, utána pedig a methodot
        public IActionResult ToDo()
        {
            return View("List", toDoRepository.ShowList());
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

        [HttpGet("/todo/add")]
        public IActionResult ViewAddForm()
        {
            return View("Add");
        }

        [HttpPost("/todo/add")]
        public IActionResult CreateListElement(ToDo toDo)
        {
            toDoRepository.CreateNewListItem(toDo);
            return Redirect("/todo");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult Delete(long id)
        {
            toDoRepository.DeleteAListItem(id);
            return RedirectToAction("List");
        }


    }
}
