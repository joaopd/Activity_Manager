using Domain.Interfaces.Repositores;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class MultiplesDeleteActivityService : IMultiplesDeleteActivityService
    {
        private readonly IActivityRepository _activity;

        public MultiplesDeleteActivityService(IActivityRepository MultiplesDeleteActivity)
        {
            _activity = MultiplesDeleteActivity;
        }

        public async Task<bool> MultiplesDeleteAsync(List<Guid> ids)
        {
            try
            {
                if (ids == null)
                    return false;

                var result = new List<Domain.Entities.Activity>();

                foreach (var id in ids)
                {
                    var activity = await _activity.GetByIdAsync(id).ConfigureAwait(false);

                    if (activity.CompleteDate != null)
                        throw new Exception($"Cannot delete completed item {id}");

                    if (activity != null)
                        result.Add(activity);
                }

                if (result == null)
                    throw new Exception("There're no items to delete");

                return await _activity.MultiplesDelete(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
