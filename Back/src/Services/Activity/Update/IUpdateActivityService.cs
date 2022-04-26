using Model.Activity;
using System.Threading.Tasks;

namespace Services.Activity
{
    public interface IUpdateActivityService
    {
        Task<UpdateActivityModelResponse> UpdateAsync(UpdateActivityModelRequest request);
    }
}
