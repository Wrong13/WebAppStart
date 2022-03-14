using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppStart.Data;
using System;
using System.Linq;
using WebAppStart.Data;

namespace WebAppStart.Data.SeeData
{
    public class DataVideoCard
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppStartContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAppStartContext>>()))
            {
                // Look for any movies.
                if (context.VideoCard.Any())
                {
                    return;   // DB has been seeded
                }

                context.VideoCard.AddRange(
                    new Models.VideoCard
                    {
                        NameCard = "PowerColor AMD Radeon 550 LP",
                        ReleaseDate = DateTime.Parse("2017-01-01"),
                        Model = "PowerColor AMD Radeon 550 LP",
                        Series = "1212",
                        Price = 19999,
                        Manufacturer = "121",
                        Image = "~Resources/Images/VideoCards/PowerColorAMDRadeonRX550 RedDragonLP.jpg"
                    },

                    new Models.VideoCard
                    {
                        NameCard = "PowerColor AMD Radeon RX 550 Red Dragon LP",
                        ReleaseDate = DateTime.Parse("2017-01-01"),
                        Model = "PowerColor AMD Radeon RX 550 Red Dragon LP",
                        Series = "PowerColor Red Dragon",
                        Price = 19999,
                        Manufacturer = "121",
                        Image = "~Resources/Images/VideoCards/PowerColorAMDRadeonRX550 RedDragonLP.jpg"
                    },

                    new Models.VideoCard
                    {
                        NameCard = "Palit GeForce RTX 3070 Ti GamingPro",
                        ReleaseDate = DateTime.Parse("2017-01-01"),
                        Model = "Palit GeForce RTX 3070 Ti GamingPro",
                        Series = "Palit Gaming Pro",
                        Price = 199999,
                        Manufacturer = "121",
                        Image = "~Resources/Images/VideoCards/PowerColorAMDRadeonRX550 RedDragonLP.jpg" 

                    },

                    new Models.VideoCard
                    {
                        NameCard = "PowerColor AMD Radeon RX 6900 XT Red Devil",
                        ReleaseDate = DateTime.Parse("2017-01-01"),
                        Model = "PowerColor AMD Radeon RX 6900 XT Red Devil",
                        Series = "PowerColor Red Devil",
                        Price = 254999,
                        Manufacturer = "121",
                        Image = "~Resources/Images/VideoCards/PowerColorAMDRadeonRX550 RedDragonLP.jpg"
                    }
                );
                context.SaveChanges();
            }
            
        }
    }
    
}
