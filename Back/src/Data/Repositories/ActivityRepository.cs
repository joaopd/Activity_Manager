using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        private readonly DataContext _context;
        public ActivityRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Activity> GetByIdAsync(Guid id)
        {
            try
            {
                IQueryable<Activity> query = _context.Activities.AsNoTracking();
                query = query
                    .OrderBy(a => a.Id == id)
                    .Where(a => a.Id.Equals(id));

                return await query.FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Activity>> GetByTitleAsync(string title)
        {
            try
            {
                IQueryable<Activity> query = _context.Activities.AsNoTracking();
                query = query
                    .OrderBy(a => a.Title == title)
                    .Where(a => a.Title.Equals(title));

                return await query.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
