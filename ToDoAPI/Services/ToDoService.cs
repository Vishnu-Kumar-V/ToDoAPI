using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Models;

namespace ToDoAPI.Services
{
    public class ToDoService : IToDoService
    {
        private List<ToDo> _toDoList;
        private int id;

        public ToDoService()
        {
            _toDoList = new List<ToDo>();
            id = 1;
        }

        public List<ToDo> GetToDoList() =>
            _toDoList;

        public ToDo GetToDoItemByID(int id) =>
            _toDoList.FirstOrDefault(t => t.id == id);

        public ToDo CreateToDoItem(ToDo newToDoItem)
        {
            newToDoItem.id = id++;
            _toDoList.Add(newToDoItem);
            return newToDoItem;
        }

        public bool UpdateToDoItem(ToDo toDoItem)
        {
            var selectedToDoItem = _toDoList.FirstOrDefault(t => t.id == toDoItem.id);
            if (selectedToDoItem != null)
            {
                selectedToDoItem.title= toDoItem.title;
                selectedToDoItem.completed = toDoItem.completed;
                return true;
            }
            return false;
        }

        public bool DeleteToDoItem(int id)
        {
            var selectedToDoItem = _toDoList.FirstOrDefault(t => t.id == id);
            if (selectedToDoItem != null)
            {
                _toDoList.Remove(selectedToDoItem);
                return true;
            }
            return false;
        }
    }
}
