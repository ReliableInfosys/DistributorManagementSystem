using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemRepository.Common
{
    public abstract class GenericRepository<T, C> : IGenericRepository<T> 
        where T : class
        where C : DbContext
    {
        private readonly C _context;

         protected GenericRepository(C context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public C Context => _context;

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity) 
        { 
            _context.Set<T>().Attach(entity);
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll() 
        {
            return _context.Set<T>();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }


    }
}
