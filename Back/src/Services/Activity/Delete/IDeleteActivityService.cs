using System;
using System.Threading.Tasks;
namespace Services.Activity
{
    public interface IDeleteActivityService
    {
        Task<bool> DeleteAsync(Guid id);
    }
}
