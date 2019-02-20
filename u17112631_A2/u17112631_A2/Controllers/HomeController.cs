using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u17112631_A2.ViewModels;
using u17112631_A2.Models;

namespace u17112631_A2.Controllers
{
    public class HomeController : Controller
    {
        static Report globalReport;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report(Report r)
        {
            if(globalReport == null)
            globalReport = r;

            if (globalReport.fromDate != r.fromDate || globalReport.toDate != r.toDate)
            {
                globalReport.fromDate = r.fromDate;
                globalReport.toDate = r.toDate;
            }

            if (globalReport.toDate == new DateTime(0001, 01, 01))
            {
                globalReport.fromDate = new DateTime(2011, 1, 31);
                globalReport.toDate = new DateTime(2012, 1, 29);
            }
 

            if (globalReport.departments ==  null)
            {

                using (HardwareDBEntities2 db = new HardwareDBEntities2())
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    var departmentsList = db.lgdepartments.ToList();
                    List<Department> departments = new List<Department>();

                    foreach (var department in departmentsList)
                    {
                        Department newDep = new Department(department.dept_name, department.dept_num, db);
                        departments.Add(newDep);
                    }

                    globalReport.setDepartments(departments);
                    TempData["chartData"] = globalReport.chartData;

                }
                
            }
        
            return View(globalReport);
        }

        public ActionResult EmployeeSalariesChart()
        {
            if(globalReport != null)
            {
                TempData["chartData"] = globalReport.chartData;

                return View(TempData["chartData"]);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}