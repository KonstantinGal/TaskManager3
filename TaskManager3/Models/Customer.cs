using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManager3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }      
    }
}