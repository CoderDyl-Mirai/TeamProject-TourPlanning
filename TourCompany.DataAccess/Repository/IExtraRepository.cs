using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public interface IExtraRepository : IRepository<Extra>
    {
        public void Update(Extra extra);
        public List<Extra> GetExtrasForTour(int id);
        public List<Extra> GetUniqueExtras();
        public List<Extra> GetExtras();



    }
}
