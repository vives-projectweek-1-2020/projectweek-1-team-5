using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using ShopReservation.Context;
using ShopReservation.Models;
using System;
using System.Linq;

namespace ShopReservation.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UserContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        UserId = 1,
                        UserName = "TestName1",
                        UserPassword = "TestPassword1",
                    },

                    new User
                    {
                        UserId = 2,
                        UserName = "TestName2",
                        UserPassword = "TestPassword2",
                    },

                    new User
                    {
                        UserId = 3,
                        UserName = "TestName3",
                        UserPassword = "TestPassword3",
                    },

                    new User
                    {
                        UserId = 4,
                        UserName = "TestName4",
                        UserPassword = "TestPassword4",
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
