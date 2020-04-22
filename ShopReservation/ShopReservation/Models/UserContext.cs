using Microsoft.EntityFrameworkCore;
using ShopReservation.Models;

namespace ShopReservation.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Movie { get; set; }
    }
}