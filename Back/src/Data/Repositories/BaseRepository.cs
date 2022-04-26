using Domain.Interfaces.Repositores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext _context;
        private DbSet<T> _dataSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            try
            {
                _dataSet.Add(entity);

                await _context.SaveChangesAsync().ConfigureAwait(false);
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                _dataSet.Remove(entity);
                await _context.SaveChangesAsync().ConfigureAwait(false);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<T>> GetList(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            try
            {
                IQueryable<T> qry = _dataSet.AsNoTracking();

                if (expression != null)
                {
                    qry = qry.Where(expression);
                }
                if (include != null)
                {
                    qry = include(qry);
                }

                return await qry.ToListAsync().ConfigureAwait(false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> MultiplesDelete(IEnumerable<T> entity)
        {
            try
            {
                _dataSet.RemoveRange(entity);

                await _context.SaveChangesAsync().ConfigureAwait(false);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> Updade(T entity)
        {
            try
            {
                _dataSet.Update(entity);

                await _context.SaveChangesAsync().ConfigureAwait(false);
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
