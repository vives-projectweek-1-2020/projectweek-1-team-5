using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopReservation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopReservation.Controllers
{
    public class PersonsController : Controller
    {
        public IList<Person> PersonList = new List<Person>
            {
                new Person() {PersonId = 0, PersonName = "Name1"},
                new Person() {PersonId = 1, PersonName = "Name2"},
                new Person() {PersonId = 2, PersonName = "Name3"},
                new Person() {PersonId = 3, PersonName = "Name4"},
                new Person() {PersonId = 4, PersonName = "Name5"},
                new Person() {PersonId = 5, PersonName = "Name6"},
            };

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View(PersonList);
        }

        public ActionResult Edit(int Id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = PersonList.Where(s => s.PersonId == Id).FirstOrDefault();

            

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Person std)
        {
            var name = std.PersonName;
            

            return RedirectToAction("Index");
        }
    }
}
