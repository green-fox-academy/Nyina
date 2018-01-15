using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDos.Entities;
using ListingToDos.Models;

namespace ListingToDos.Repositories
{
    public class ToDoRepository
    {
        public ToDoContext toDoContext;

        public ToDoRepository (ToDoContext toDoContext)
        {
            this.toDoContext = toDoContext;
        }

        //ez a lista nem kell, csak a kiíratást néztük meg vele
        //public List<ToDo> todoList = new List<ToDo>()
        //{
        //   new ToDo() { Title = "Start the day" },
        //   new ToDo() { Title = "Finish H2 workshop1" },
        //   new ToDo() { Title = "Finish JPA workshop2" },
        //   new ToDo() { Title = "Create a CRUD project" }
        //};

        public List<ToDo> ShowList()
        {
            //A context todo dbset-jét listává kell alakítani
            //és eztv a controllerben meg kell hívni
            return toDoContext.ToDosSet.ToList();
        }

    }
}
