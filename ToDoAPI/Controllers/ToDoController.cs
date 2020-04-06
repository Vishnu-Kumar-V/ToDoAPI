using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;
using ToDoAPI.Services;

namespace ToDoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        IToDoService _toDoService;
        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        public List<ToDo> GetToDoList()
        {
            return _toDoService.GetToDoList();
        }

        [HttpGet("{id}")]
        public ToDo GetToDoItemById(int id)
        {
            return _toDoService.GetToDoList().FirstOrDefault(t => t.id == id);
        }

        [HttpPost]
        public ToDo CreateToDoItem(ToDo todoItem)
        {
            return _toDoService.CreateToDoItem(todoItem);
        }

        [HttpPut]
        public IActionResult UpdateToDoItem(ToDo todoItem)
        {
            var returnVal = _toDoService.UpdateToDoItem(todoItem);
            if (returnVal)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public IActionResult DeleteToDoItem(int id)
        {
            var returnVal = _toDoService.DeleteToDoItem(id);
            if (returnVal)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}