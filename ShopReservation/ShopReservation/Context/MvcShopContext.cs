using Microsoft.EntityFrameworkCore;
using ShopReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopReservation.Context
{
    public class MvcShopContext : DbContext
    {
        public MvcShopContext (DbContextOptions<MvcShopContext> options)
            :base(options)
        {
        }

        public DbSet<ShopModel> Shop { get; set; }
    }
}
