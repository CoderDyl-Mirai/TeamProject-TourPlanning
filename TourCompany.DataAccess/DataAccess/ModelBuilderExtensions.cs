using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.DataAccess
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>()
                .HasData(
                new Tour { Name = "Glenveagh Walking Tour", Description = "Discover Glenveagh National Park on a scenic walking tour through rugged mountains, peaceful lakeshores, and native woodland. Follow tranquil paths to Glenveagh Castle, explore beautiful gardens, and experience breathtaking views, rich wildlife, and the park’s unique natural and cultural heritage.", Price = 15.00m, Image = @"\Images\Products\Glenveagh.jpg", MaxCapacity = 20, MinCapacity = 5, Duration = 120, Date =  }
                );
        }
    }
}
