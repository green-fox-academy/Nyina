using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDos.Entities;
using ListingToDos.Models;
using Microsoft.EntityFrameworkCore;

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
            //és ezt a controllerben meg kell hívni
            return toDoContext.ToDos.Include(x => x.User).ToList();
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

        public void CreateNewTodo(ToDo ToDo, string Name)
        {
            var oneUser = GetAUser(Name);
            if(oneUser == null)
            {
                var userObject = new User();
                userObject.Name = Name;
                ToDo.User = userObject;
            }
            else
            {
                ToDo.User = oneUser;
            }
            toDoContext.ToDos.Add(ToDo);
            toDoContext.SaveChanges();
        }

        public void CreateNewUser(User user)
        {
            toDoContext.Users.Add(user);
            toDoContext.SaveChanges();
        }

        public void DeleteAUser(long index)
        {
            User userToDelete = toDoContext.Users.FirstOrDefault(x => x.UserId == index);
            toDoContext.Users.Remove(userToDelete);
            toDoContext.SaveChanges();
        }

        public void DeleteAListItem(long index)
        {
            //ToDo t = toDoContext.ToDos.Find(index);
            ToDo itemToDelete = toDoContext.ToDos.FirstOrDefault(x => x.ToDoId == index);
            toDoContext.ToDos.Remove(itemToDelete);
            toDoContext.SaveChanges();
        }

        public void EditAListItem(ToDo todo, long index, string Name)
        {
            //ToDo t = toDoContext.ToDos.FirstOrDefault(x => x.ToDoId == index);
            ToDo t = toDoContext.ToDos.Include(x => x.User).FirstOrDefault(x => x.ToDoId == index);
            t.Title = todo.Title;

            var oneUser = GetAUser(Name);
            if (oneUser == null)
            {
                var newUser = new User();
                newUser.Name = Name;
                t.User = newUser;
            }
            t.User = oneUser;

            t.IsDone = todo.IsDone;
            t.IsUrgent = todo.IsUrgent;
            toDoContext.SaveChanges();
        }

        public ToDo GetAListItem(long index)
        {
            //1 db todo-t adunk vissza
            return toDoContext.ToDos.Include(x => x.User).FirstOrDefault(x => x.ToDoId == index);
        }

        public List<ToDo> GetAUsersListItem(long id)
        {
            return toDoContext.ToDos.Where(t => t.User.UserId == id).ToList();
        }

        public User GetAUser(string Name)
        {
            return toDoContext.Users.FirstOrDefault(x => x.Name == Name);
        }

        public List<ToDo> GetASearchedElement(string searchedString)
        {
            //return toDoContext.ToDos.Include(x => x.User).Where(t => t.Title.Contains(searchedString)).ToList();
            return toDoContext.ToDos.Include(x => x.User)
                .Where(t => (t.Title.Contains(searchedString)) || (t.Date.Contains(searchedString)) || (t.User.Name.Contains(searchedString)))
                .ToList();
        }
    }
}
