using ExercisePerson.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ExercisePerson.Controllers
{
    public class PersonController : Controller
    {
        private static readonly IList<Person> PersonList = new List<Person>();


        public ActionResult Index() => View(PersonList);

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

            return RedirectToAction($"Index");
        }
    }
}