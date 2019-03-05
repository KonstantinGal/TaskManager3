using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManager3.Models;

namespace TaskManager3.ViewModel
{
    public class TaskListViewModel
    {
        public Customer Customer { get; set; }
        public List<CustomerTask> CustomerTasks { get; set; }

    }
}