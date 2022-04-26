using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Services.Activity
{
    public interface IMultiplesDeleteActivityService
    {
        Task<bool> MultiplesDeleteAsync(List<Guid> ids);
    }
}
