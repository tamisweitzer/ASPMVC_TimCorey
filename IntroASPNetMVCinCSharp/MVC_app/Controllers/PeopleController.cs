using MVC_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_app.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Tami", LastName = "Sweitzer", Age = 49 });
            people.Add(new PersonModel { FirstName = "Toni", LastName = "Swesher", Age = 49 });
            people.Add(new PersonModel { FirstName = "Tori", LastName = "Swetzler", Age = 49 });

            return View(people);
        }
    }
}