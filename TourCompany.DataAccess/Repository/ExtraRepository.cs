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
        public void Update(Extra extra)
        {
            var extraFromDB = _dBContext.Tours.FirstOrDefault(extraFromDB => extraFromDB.Id == extra.Id);
            extraFromDB.Name = extra.Name;
            extraFromDB.Description = extra.Description;
            extraFromDB.Price = extra.Price;
            extraFromDB.Id = extra.TourId;
        }
    }
}
