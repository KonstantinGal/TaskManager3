using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager3.Models
{
    public class CustomerTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public bool IsCompleted { get; set; }
    }
}