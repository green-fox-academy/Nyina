using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.ViewModels;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    [Route("")]
    public class ToDoController : Controller
    {
        private ToDoAppViewModel todoVM;
        //Ezt is fieldbe kell tenni, aztán consturktorba? Vagy elég csak a Viewmodelt?
        private ToDo todo;

        public ToDoController(ToDoAppViewModel todoVM, ToDo todo)
        {
            this.todoVM = todoVM;
            this.todo = todo;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(todoVM);
        }

        [HttpPost("add")]
        public IActionResult AddItem(ToDo todo)
        {
            todoVM.ToDoList.Add(todo);
            return RedirectToAction("Index");
        }

        [HttpPost("remove")]
        public IActionResult RemoveItem(int number)
        {
            todoVM.ToDoList.RemoveAt(number);
            return RedirectToAction("Index");
        }
    }
}
