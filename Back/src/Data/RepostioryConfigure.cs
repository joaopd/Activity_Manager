using Data.Repositories;
using Domain.Interfaces.Repositores;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class RepostioryConfigure
    {
        public static void AddRepostioryConfigure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IActivityRepository, ActivityRepository>();
        }
    }
}
