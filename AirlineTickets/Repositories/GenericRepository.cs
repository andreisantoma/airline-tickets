using AirlineTickets.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AirlineTickets.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AirlineTicketsContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AirlineTicketsContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Delete(object id)
        {
            T entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public IEnumerable<T> Get(
                Expression<Func<T, bool>> predicate = null,
                List<string> includeProperties = null
            )
        {
            IQueryable<T> to_return = _dbSet;
            if (predicate != null)
            {
                to_return = to_return.Where(predicate);
            }
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    to_return = to_return.Include(includeProperty);
                }
            }

            return to_return;
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
