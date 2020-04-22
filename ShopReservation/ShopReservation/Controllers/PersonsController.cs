using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopReservation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopReservation.Controllers
{
    public class PersonsController : Controller
    {

        private UserContext _context;

        public PersonsController(UserContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            
            return  View(await _context.User.ToListAsync());
        }

        public ActionResult Edit(int Id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            //var std = PersonList.Where(s => s.PersonId == Id).FirstOrDefault();

            

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Person std)
        {
            var name = std.PersonName;
            

            return RedirectToAction("Index");
        }
    }
}
