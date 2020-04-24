using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ShopReservation.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        [DisplayName("Shop name")]
        public string Name { get; set; }
        public string Time { get; set; }
        [DisplayName("Reserved Spots")]
        public int Reserved { get; set; }
        [DisplayName("Max amount of spots")]
        public int Spots { get; set; }
    }
}
