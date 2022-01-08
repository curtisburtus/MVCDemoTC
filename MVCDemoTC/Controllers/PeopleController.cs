using MVCDemoTC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoTC.Controllers
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

            people.Add(new PersonModel { FirstName = "Tom", LastNamge = "Delonge" });
            people.Add(new PersonModel { FirstName = "Mark", LastNamge = "Hoppus" });
            people.Add(new PersonModel { FirstName = "Travis", LastNamge = "Barker" });

            return View(people);
        }
    }
}