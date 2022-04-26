using Domain.Interfaces.Repositores;
using Model.Activity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class GetAllActivityService : IGetAllActivityService
    {
        private readonly IActivityRepository _activity;

        public GetAllActivityService(IActivityRepository GetAllActivity)
        {
            _activity = GetAllActivity;
        }

        public async Task<GetAllModelResponse> GetAllAsync()
        {
            try
            {
                var result = await _activity.GetList().ConfigureAwait(false);

                return result == null ?
                    null :
                    Convert(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private GetAllModelResponse Convert(List<Domain.Entities.Activity> request)
        {
            var models = new List<GetActivityModel>();

            foreach (var activity in request)
            {
                var model = new GetActivityModel
                {
                    Id = activity.Id,
                    Description = activity.Description,
                    Priority = (Model.Enums.PriorityEnumModel)activity.Priority,
                    Number = activity.Number,
                    CompleteDate = activity.CompleteDate,
                    CreateDate = activity.CreateDate,
                    Title = activity.Title
                };

                models.Add(model);
            }

            return new GetAllModelResponse
            {
                Activities = models
            };
        }
    }
}
