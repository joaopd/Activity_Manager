using Domain.Interfaces.Repositores;
using System;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class CompleteActivityService : ICompleteActivityService
    {
        private readonly IActivityRepository _activity;

        public CompleteActivityService(IActivityRepository CompleteActivity)
        {
            _activity = CompleteActivity;
        }

        public async Task<bool> CompleteAsync(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                    throw new Exception("Response not can be null");

                var exist = await _activity.GetByIdAsync(id);

                if (exist == null)
                    throw new Exception("Item not exists");

                exist.SetCompleted();

                var result = await _activity.Updade(exist);
                if (result == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
