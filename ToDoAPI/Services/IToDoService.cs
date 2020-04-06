using System.Collections.Generic;
using ToDoAPI.Models;

namespace ToDoAPI.Services
{
    public interface IToDoService
    {
        List<ToDo> GetToDoList();

        ToDo GetToDoItemByID(int id);
        
        ToDo CreateToDoItem(ToDo newToDoItem);

        bool UpdateToDoItem(ToDo toDoItem);

        bool DeleteToDoItem(int id);
    }
}