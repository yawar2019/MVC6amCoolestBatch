using MVC6amCoolestBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6amCoolestBatch.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public string Index()//5x5=25 lines
        {
            return "Hello World";
        }

        [Route("Maths/addition")]
        [Route("Maths/subtraction")]
        [Route("Maths/Multiplication")]//Attribute based Routing
        public int Index2()//5
        {
            return 1211;
        }


        public ActionResult Index3()//5
        {
            return View("Test");
        }

        public ActionResult Index4()
        {
            return View("~/Views/Default/Index.cshtml");
        }
        public ActionResult Index5()
        {
            ViewBag.EmpName = "Naresh";
            return View();
        }
        public ActionResult Index6()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

            ViewBag.Emp = emp;
            return View();
        }

        public ActionResult Index7()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Sandeep";
            emp1.EmpSalary = 203933;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Neelima";
            emp2.EmpSalary = 303933;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            ViewBag.listEmp = listEmp;
           
            return View();
        }

        public ActionResult Index8()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

           //object model =emp;
            return View(emp);
        }

        public ActionResult Index9()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Sandeep";
            emp1.EmpSalary = 203933;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Neelima";
            emp2.EmpSalary = 303933;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            //object model =listEmp;
            return View(listEmp);
        }
        public ViewResult Index10()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Sandeep";
            emp1.EmpSalary = 203933;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Neelima";
            emp2.EmpSalary = 303933;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);
            ////////////////Dept

            List<DepartmentModel> listDepartment = new List<DepartmentModel>();
            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1211;
            dept.DeptName = "IT";
            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1212;
            dept1.DeptName = "Network";

            listDepartment.Add(dept);
            listDepartment.Add(dept1);

            EmpDept empdeptObj = new Models.EmpDept();
            empdeptObj.Emp =listEmp;
            empdeptObj.dept =listDepartment;


            //object model =listEmp;
            return View(empdeptObj);
        }

        public RedirectResult Redirect1()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult Redirect2()
        {
            return Redirect("~/new/index10");
        }

        public FileResult GetFile()
        {
            return File("~/Web.config", "text/plain");
        }

        public FileResult GetFileinXml()
        {
            return File("~/Web.config", "application/xml");
        }
        public FileResult GetFileinPDF()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
        public FileResult GetFileDownLoad()
        {
            return File("~/ActionResult.pdf", "application/pdf","ActionResult.pdf");
        }

        public JsonResult getjsonData()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Sandeep";
            emp1.EmpSalary = 203933;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Neelima";
            emp2.EmpSalary = 303933;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);
            ////////////////Dept

            List<DepartmentModel> listDepartment = new List<DepartmentModel>();
            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1211;
            dept.DeptName = "IT";
            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1212;
            dept1.DeptName = "Network";

            listDepartment.Add(dept);
            listDepartment.Add(dept1);

            EmpDept empdeptObj = new Models.EmpDept();
            empdeptObj.Emp = listEmp;
            empdeptObj.dept = listDepartment;

            return Json(empdeptObj,JsonRequestBehavior.AllowGet);

        }


        public JsonResult getjsonData2()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Naresh";
            emp.EmpSalary = 103933;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Sandeep";
            emp1.EmpSalary = 203933;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Neelima";
            emp2.EmpSalary = 303933;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);
            

            return Json(listEmp, JsonRequestBehavior.AllowGet);

        }

        public ActionResult LoadEmployeefromJsonData()
        {
            return View();
        }
    }
}