using Microsoft.AspNetCore.Mvc;
using Model.Activity;
using Services.Activity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Post(
            [FromBody] AddActivityModelRequest request,
            [FromServices] IAddActivityService addActivity)
        {
            try
            {
                var result = await addActivity
                     .AddAsync(request)
                     .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception("", e);
            }
        }
        [HttpGet("")]
        public async Task<IActionResult> Get(
            [FromServices] IGetAllActivityService getAllActivity)
        {
            try
            {
                var result = await getAllActivity
                    .GetAllAsync()
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id,
            [FromServices] IGetByIdActivityService getByIdActivity)
        {
            try
            {
                var result = await getByIdActivity
                    .GetByIdAsync(id)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id,
            [FromServices] IUpdateActivityService updateActivity,
            [FromBody] UpdateActivityModelRequest request)
        {
            if (request.Id != id)
                throw new Exception("Voce esta tentando atualizar uma Activity errada");

            try
            {
                var result = await updateActivity
                    .UpdateAsync(request)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id,
            [FromServices] IDeleteActivityService deleteActivity)
        {
            try
            {
                var result = await deleteActivity
                    .DeleteAsync(id)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }

        [HttpDelete("")]
        public async Task<IActionResult> MultiplesDelete(List<Guid> ids,
           [FromServices] IMultiplesDeleteActivityService multiplesDeleteActivity)
        {
            try
            {
                var result = await multiplesDeleteActivity
                    .MultiplesDeleteAsync(ids)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
        [HttpPut("complete/{id}")]
        public async Task<IActionResult> Complete(Guid id,
        [FromServices] ICompleteActivityService completeActivity)
        {
            try
            {
                var result = await completeActivity
                    .CompleteAsync(id)
                    .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
    }
}