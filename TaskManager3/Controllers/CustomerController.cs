﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskManager3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}