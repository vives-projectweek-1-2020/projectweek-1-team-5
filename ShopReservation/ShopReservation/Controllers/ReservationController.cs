using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopReservation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopReservation.Controllers
{
    public class ReservationController : Controller
    {   

        //public List<ShopModel> ;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
