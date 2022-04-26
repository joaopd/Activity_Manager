using Model.Activity;
using System;
using System.Threading.Tasks;

namespace Services.Activity
{
    public interface IAddActivityService
    {
        Task<Guid> AddAsync(AddActivityModelRequest request);
    }
}
