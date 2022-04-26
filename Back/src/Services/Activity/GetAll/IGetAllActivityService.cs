using Model.Activity;
using System.Threading.Tasks;
namespace Services.Activity
{
    public interface IGetAllActivityService
    {
        Task<GetAllModelResponse> GetAllAsync();
    }
}
