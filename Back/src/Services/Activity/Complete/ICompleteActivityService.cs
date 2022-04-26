using System;
using System.Threading.Tasks;
namespace Services.Activity
{
    public interface ICompleteActivityService
    {
        Task<bool> CompleteAsync(Guid id);
    }
}
