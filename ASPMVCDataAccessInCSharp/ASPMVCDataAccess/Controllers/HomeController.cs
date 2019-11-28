using ASPMVCDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace ASPMVCDataAccess.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employee List";
            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
             
            foreach( var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    ConfirmEmailAddress = row.EmailAddress
                });

            }
            return View(employees);
        }

        // GET - for when you load, or GET, the initial form
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign up";
            return View();
        }

        // POST- for when you've filled out the form and you need to POST that information back to the server
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee         (model.EmployeeId, model.FirstName, 
                   model.LastName, model.EmailAddress);
                
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}