using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopReservation.Models
{
    public class ShopModel
    {
        public string ShopName { get; set; }
        public int Reservations { get; set; }
        public int MaxReservations { get; set; }
    }
}
