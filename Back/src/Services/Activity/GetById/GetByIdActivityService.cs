using Domain.Interfaces.Repositores;
using Model.Activity;
using System;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class GetByIdActivityService : IGetByIdActivityService
    {
        private readonly IActivityRepository _activity;

        public GetByIdActivityService(IActivityRepository GetByIdActivity)
        {
            _activity = GetByIdActivity;
        }

        public async Task<GetActivityModel> GetByIdAsync(Guid id)
        {
            try
            {
                var result = await _activity.GetByIdAsync(id).ConfigureAwait(false);

                return result == null ?
                    null :
                    Convert(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private GetActivityModel Convert(Domain.Entities.Activity request)
        {

            return new GetActivityModel
            {
                Id = request.Id,
                Description = request.Description,
                Priority = (Model.Enums.PriorityEnumModel)request.Priority,
                Number = request.Number,
                CompleteDate = request.CompleteDate,
                CreateDate = request.CreateDate,
                Title = request.Title
            };
        }
    }
}
