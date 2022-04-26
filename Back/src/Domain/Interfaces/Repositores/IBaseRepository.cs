using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositores
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Updade(T entity);
        Task<bool> Delete(T entity);
        Task<bool> MultiplesDelete(IEnumerable<T> entity);
        Task<List<T>> GetList(Expression<Func<T, bool>> expression = null,
                   Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
