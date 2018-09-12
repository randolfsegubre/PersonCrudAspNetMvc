using ExercisePerson.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ExercisePerson.Controllers
{
    public class PersonController : Controller
    {
        private static IList<Person> PersonList = new List<Person>
        {
            new Person{
                Id = 1,
                FirstName = "Randolf",
                LastName = "Segubre",
                DateOfBirth = DateTime.Parse("08/28/1991"),
                Email = "rsegubre@gmail.com",
            },

            new Person{
                Id = 2,
                FirstName = "Ganises Eva",
                LastName = "Segubre",
                DateOfBirth = DateTime.Parse("11/25/1991"),
                Email = "rsegubre@gmail.com" }
        };

        public ActionResult Index()
        {
            //var PersonList = new List<Person>();
            //PersonList.Add(new Person { FirstName = "Randolf" });
            //PersonList.Add(new Person { FirstName = "Ganises Eva" });
            return View(PersonList);
        }

        //public ActionResult AddPerson()
        //{
        //    return View();
        //}
        //[HttpPost]
        public ActionResult AddPerson(Person addPerson)
        {
            if (!ModelState.IsValid)
            {
                return View(addPerson);
            }

            PersonList.Add(new Person
            {
                Id = PersonList.Count + 1,
                FirstName = addPerson.FirstName,
                LastName = addPerson.LastName,
                DateOfBirth = addPerson.DateOfBirth,
                Email = addPerson.Email,
            });

            return RedirectToAction("Index");
        }
    }
}