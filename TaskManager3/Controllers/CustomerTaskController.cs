using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager3.Models;
using TaskManager3.ViewModel;

namespace TaskManager3.Controllers
{
    public class CustomerTaskController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerTaskController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult TaskList()
        {
            var customerTasks = _context.CustomerTasks.ToList();

            return View(customerTasks);
        }
    }
}