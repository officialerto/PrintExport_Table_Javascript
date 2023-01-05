using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrintExport_Table_jQuery.Models;

namespace PrintExport_Table_jQuery.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            List<Employee> emplist = new List<Employee>();
            using (DbModels db = new DbModels())
            {
                emplist = db.Employees.ToList<Employee>();
                return Json(new { data = emplist }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }
    }
}