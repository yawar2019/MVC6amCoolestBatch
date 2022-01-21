﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using DapperExample.Models;
namespace DapperExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {

            return View(db.GetEmployees());
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel Emp)
        {
            int result = db.SaveEmployees(Emp);
            if (result > 0)
                return RedirectToAction("Index");
            return View();
        }

        public ActionResult Edit(int? id )
        {
            var Emp =db.GetEmployeesById(id);
            return View(Emp);
        }
    }
}