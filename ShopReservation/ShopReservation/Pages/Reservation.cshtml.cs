using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SupermarkCheck.Pages
{
    public class ReservationModel : PageModel
    {
        public void OnGet()
        {

        }

        public string AddReservation()
        {
            return "added";
        }
    }
}