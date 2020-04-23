using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopReservation.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public int Reserved { get; set; }
        public int Spots { get; set; }
    }
}
