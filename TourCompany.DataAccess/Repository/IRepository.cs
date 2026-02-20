using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        T? Get(int id);
        IEnumerable<T> GetAll(Expression<Func<T, object>>? include = null);

    }
}
