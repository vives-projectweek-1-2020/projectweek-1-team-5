using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopReservation.Models
{
    public class Person
    {
        
            public int PersonId { get; set; }

            [Display(Name = "Name")]
            public string PersonName { get; set; }
            public string PassWord { get; set; }
    }
}
