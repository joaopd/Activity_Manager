using Domain.Interfaces.Repositores;
using Model.Activity;
using System;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class UpdateActivityService : IUpdateActivityService
    {
        private readonly IActivityRepository _activity;

        public UpdateActivityService(IActivityRepository UpdateActivity)
        {
            _activity = UpdateActivity;
        }

        public async Task<UpdateActivityModelResponse> UpdateAsync(UpdateActivityModelRequest request)
        {
            if (request == null)
                throw new Exception("Response not can be null");

            var exist = await _activity.GetByIdAsync(request.Id);

            if (exist == null)
                throw new Exception("Item not foud");

            if (request.Title != null)
            {
                exist.SetTitle(request.Title);
            }

            if (request.Description != null)
            {
                exist.SetDescription(request.Description);
            }

            exist.SetPriority((Domain.Enums.PriorityEnum)request.Priority); ;


            await _activity.Updade(exist);

            return Convert(exist);
        }

        private UpdateActivityModelResponse Convert(Domain.Entities.Activity request)
        {
            return new UpdateActivityModelResponse
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
