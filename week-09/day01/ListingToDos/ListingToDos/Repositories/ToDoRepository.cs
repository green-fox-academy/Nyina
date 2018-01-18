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
        private ToDoContext toDoContext;

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
            //toDoContext.ToDos.Add(new ToDo { Title = "A" });
            return toDoContext.ToDos.ToList();
        }

        public List<ToDo> ShowListOfIsActive()
        {
            return toDoContext.ToDos.Where(t => t.IsDone == false).ToList();
        }

        public List<ToDo> DecideListType(bool IsActive)
        {
            if (IsActive)
            {
                return ShowListOfIsActive();
            }
            else
            {
                return ShowList();
            }
        }

        public void CreateNewListItem(ToDo ToDo)
        {
            toDoContext.ToDos.Add(ToDo);
            toDoContext.SaveChanges();
        }

        public void DeleteAListItem(long index)
        {
            //ToDo t = toDoContext.ToDos.Find(index);
            ToDo t = toDoContext.ToDos.FirstOrDefault(x => x.ToDoId == index);
            toDoContext.ToDos.Remove(t);
            toDoContext.SaveChanges();
        }

        public void EditAListItem(ToDo todo, long index)
        {
            ToDo t = toDoContext.ToDos.FirstOrDefault(x => x.ToDoId == index);
            t.Title = todo.Title;
            t.User = todo.User;
            t.IsDone = todo.IsDone;
            t.IsUrgent = todo.IsUrgent;
            toDoContext.SaveChanges();
        }

        public ToDo GetAListItem(long index)
        {
            //1 db todo-t adunk vissza
            return toDoContext.ToDos.FirstOrDefault(x => x.ToDoId == index);
        }

    }
}
