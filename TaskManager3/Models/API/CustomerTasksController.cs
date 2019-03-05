using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskManager3.Models.API
{
    public class CustomerTasksController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomerTasksController()
        {
            _context = new ApplicationDbContext();
            
        }
        public IEnumerable<CustomerTask> GetCustomerTasks()
        {
            return _context.CustomerTasks.ToList();
        }

    
        public CustomerTask GetCustomerTask(int id)
        {
            var customerTask = _context.CustomerTasks.SingleOrDefault(c => c.Id == id);

            return customerTask;
        }

        [HttpPost]
        public IHttpActionResult CreateCustomerTask(CustomerTask customerTask)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
            _context.CustomerTasks.Add(customerTask);
            _context.SaveChanges();

            
            return Created(new Uri(Request.RequestUri + "/" + customerTask.Id), customerTask);
        }

        [HttpPut]
        public void UpdateCustomerTask(int id, CustomerTask customerTask)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
            var customerTaskInDb = _context.CustomerTasks.SingleOrDefault(c => c.Id == id);

            if (customerTaskInDb == null)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());


            customerTaskInDb.Name = customerTask.Name;
            customerTaskInDb.Details = customerTaskInDb.Details;
            customerTaskInDb.IsCompleted = customerTaskInDb.IsCompleted;

            _context.SaveChanges();
        }
    }
}
