using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult index()
        {
            //empcontext Empcontext = new empcontext();
            //List<dbemp> DBemp = Empcontext.empDB.ToList();
            //List<dbemp> emp=new List<dbemp>();
            return View();
        }

        [HttpPost]
        public ActionResult index1()
        {
            empcontext Empcontext = new empcontext();
            List<dbemp> DBemp = Empcontext.empDB.ToList();
            return Json(DBemp);
        }
        
        public ActionResult details()
        {


            employee emp = new employee();
            //emp.details = new List<employee>();
            //    emp_id = 101,
            //emp_name = "Nirav"
            //};
            
            //{
            //    new employee { emp_id = 10 , emp_name = "abc" },
            //    new employee { emp_id = 20 , emp_name = "xyz" }
            //};
            emp.details.Add(new employee {
                emp_id = 30,
                emp_name = "pqr"
            });

            return View(emp);
        }

        public ActionResult dbdetails(int id)
        {
            empcontext Empcontext = new empcontext();
            dbemp Dbemp = Empcontext.empDB.Single(emp => emp.emp_id == id);
            return View(Dbemp);
        }

        public ActionResult edit(int id)
        {
            empcontext Empcontext = new empcontext();
            dbemp Dbemp = Empcontext.empDB.Single(emp => emp.emp_id == id);
            return View(Dbemp);
        }

        public ActionResult delete(int id)
        {
            empcontext Empcontext = new empcontext();
            dbemp Dbemp = Empcontext.empDB.Single(emp => emp.emp_id == id);
            Empcontext.empDB.Remove(Dbemp);
            Empcontext.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpPost]
        public ActionResult edit(dbemp model)
        {
            empcontext Empcontext = new empcontext();
            var data= Empcontext.empDB.FirstOrDefault(o => o.emp_id == model.emp_id);
            data.emp_name = model.emp_name;
            //Empcontext.empDB.Add(data);
            Empcontext.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(dbemp model)
        {
            empcontext Empcontext = new empcontext();
            //var data = Empcontext.empDB.FirstOrDefault(o => o.emp_id == model.emp_id);
            //data.emp_name = model.emp_name;
            Empcontext.empDB.Add(model);
            Empcontext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}