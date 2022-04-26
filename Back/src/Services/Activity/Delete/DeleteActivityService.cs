using Domain.Interfaces.Repositores;
using System;
using System.Threading.Tasks;

namespace Services.Activity
{
    public class DeleteActivityService : IDeleteActivityService
    {
        private readonly IActivityRepository _activity;

        public DeleteActivityService(IActivityRepository DeleteActivity)
        {
            _activity = DeleteActivity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                    throw new Exception("Response not can be null");

                var exist = await _activity.GetByIdAsync(id);

                if (exist == null)
                    throw new Exception("Item not exists");

                if (exist.CompleteDate != null)
                    throw new Exception("Cannot delete completed item");

                return await _activity.Delete(exist);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
