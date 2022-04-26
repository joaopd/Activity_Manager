using Model.Activity;
using System;
using System.Threading.Tasks;
namespace Services.Activity
{
    public interface IGetByIdActivityService
    {
        Task<GetActivityModel> GetByIdAsync(Guid id);
    }
}
