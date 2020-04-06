using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Models
{
    public class ToDo
    {
        public int id { get; set; }

        public string title { get; set; }

        public bool completed { get; set; } = false;
    }
}
