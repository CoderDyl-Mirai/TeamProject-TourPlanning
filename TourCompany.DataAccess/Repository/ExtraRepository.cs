using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public class ExtraRepository: Repository<Extra>, IExtraRepository
    {
        private readonly TourDBContext _dBContext;
        public ExtraRepository(TourDBContext dbContext) : base(dbContext)
        {
            _dBContext = dbContext;
        }
        public List<Extra> GetExtrasForTour(int id)
        {
            var tourExtras = _dBContext.Extras.Where(b => b.TourId == id).ToList();
            return tourExtras;
        }
        public List<Extra> GetUniqueExtras()
        {
            var tourExtras = _dBContext.Extras
         .GroupBy(e => e.Name)  
         .Select(g => g.First())
         .ToList();
            return tourExtras;

        }

        public List<Extra> GetExtras()
        {
            var tourExtras = _dBContext.Extras
         .ToList();
            return tourExtras;

        }


    }
}
