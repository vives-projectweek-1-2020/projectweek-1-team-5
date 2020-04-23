using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopReservation.Controllers
{
    public class ShopRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}