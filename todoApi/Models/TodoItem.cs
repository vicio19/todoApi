using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string name { get; set; }
        public bool IsComplete { get; set; }
    }
}
