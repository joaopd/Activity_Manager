using Domain.Interfaces.Repositores;
using Model.Activity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class AddActivityService : IAddActivityService
    {
        private readonly IActivityRepository _activity;

        public AddActivityService(IActivityRepository addActivity)
        {
            _activity = addActivity;
        }

        public async Task<Guid> AddAsync(AddActivityModelRequest request)
        {
            if (request == null)
                throw new Exception("Response not can be null");

            var activity = new Domain.Entities.Activity(request.Title, request.Description, (Domain.Enums.PriorityEnum)request.Priority);

            var exist = await _activity.GetByTitleAsync(activity.Title);

            if (exist.Count() > 0)
                throw new Exception("Item already exists");

            await _activity.Add(activity);

            return activity.Id;
        }
    }
}
