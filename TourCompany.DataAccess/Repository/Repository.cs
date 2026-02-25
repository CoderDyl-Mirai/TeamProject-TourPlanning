using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DataAccess.DataAccess;

namespace TourCompany.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TourDBContext _dbContext;
        internal DbSet<T> dbSet;
        public Repository(TourDBContext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<T>();
        }
        public void Add(T obj)
        {
            dbSet.Add(obj);
        }
        public void Delete(T obj)
        {
            dbSet.Remove(obj);
        }
        public void Update(T obj)
        {
            dbSet.Update(obj);
        }
        public T? Get(int id)
        {
            if (id == 0) return null;
            else return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, object>>? include = null)
        {
            IQueryable<T> list = dbSet;
            if (include != null)
            {
                list = list.Include(include);
            }
            return list.ToList();
        }
    }
}
