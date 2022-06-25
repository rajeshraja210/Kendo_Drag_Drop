using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult EmployeeList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Employee> _emp = new List<Employee>();
                _emp.Add(new Employee(1, "apple", "Ross1"));
                _emp.Add(new Employee(2, "ball", "Raj2"));
                _emp.Add(new Employee(3, "cat", "Kumar"));
                _emp.Add(new Employee(4, "doll", "Ross"));
                _emp.Add(new Employee(5, "elephant", "Raj"));
                _emp.Add(new Employee(6, "fail", "Kumar"));
                _emp.Add(new Employee(7, "gap", "Ross"));
                _emp.Add(new Employee(8, "hocky", "Raj"));
                _emp.Add(new Employee(9, "india", "Kumar"));
                _emp.Add(new Employee(10, "jail", "Ross"));
                _emp.Add(new Employee(11, "kolor", "Raj"));
                _emp.Add(new Employee(12, "loan", "Kumar"));
                DataSourceResult result = _emp.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}