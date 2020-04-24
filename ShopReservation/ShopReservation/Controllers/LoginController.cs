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
    public class LoginController : Controller
    {

        private UserContext _context;

        public LoginController(UserContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }

        // POST: api/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult<User>> Login(User user)
        {
            if (user == null)
            {
                return NotFound();
            }

            var userLogin = await _context.User.SingleOrDefaultAsync(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword);

            if (userLogin == null)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "ShopModels");
        }


        public IActionResult LoggedIn()
        {
            return View();
        }

        
    }
}
