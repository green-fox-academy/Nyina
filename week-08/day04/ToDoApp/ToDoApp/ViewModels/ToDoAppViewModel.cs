using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class ToDoAppViewModel
    {
        public List<ToDo> ToDoList = new List<ToDo>();

        public ToDoAppViewModel()
        {
            AddListElements();
        }

        public void AddListElements()
        {
            ToDoList.Add(new ToDo()
            {
                Task = "Make a tea",
                Urgent = true,
            });

            ToDoList.Add(new ToDo()
            {
                Task = "Read a book",
                Urgent = true,
            });

            ToDoList.Add(new ToDo()
            {
                Task = "Washing up",
                Urgent = false,
            });
        }

        public List<ToDo> RemoveListElements(int number)
        {
            ToDoList.RemoveAt(number);
            return ToDoList;
        }
    }
}
