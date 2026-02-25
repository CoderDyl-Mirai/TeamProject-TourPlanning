using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public class TourRepository : Repository<Tour>, ITourRepository
    {
        private readonly TourDBContext _dBContext;
        public TourRepository(TourDBContext dbContext) : base(dbContext)
        {
            _dBContext = dbContext;
        }
        public void Update(Tour tour)
        {
            var tourFromDB = _dBContext.Tours.FirstOrDefault(tourFromDB => tourFromDB.Id == tour.Id);
            tourFromDB.Name = tour.Name;
            tourFromDB.Description = tour.Description;
            tourFromDB.Price = tour.Price;
            tourFromDB.MaxCapacity = tour.MaxCapacity;
            tourFromDB.MinCapacity = tour.MinCapacity;
            tourFromDB.Duration = tour.Duration;
            tourFromDB.Date = tour.Date;
            tourFromDB.Location = tour.Location;


            if (tour.Image != null)
            {
                tourFromDB.Image = tour.Image;
            }
        }
    }
}
