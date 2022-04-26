using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositores
{
    public interface IActivityRepository : IBaseRepository<Activity>
    {
        Task<Activity> GetByIdAsync(Guid id);
        Task<IEnumerable<Activity>> GetByTitleAsync(string title);
    }
}
