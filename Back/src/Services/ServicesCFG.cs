using Microsoft.Extensions.DependencyInjection;
using Services.Activity;

namespace Services
{
    public static class ServicesCFG
    {
        public static void AddServices(this IServiceCollection services)
        {
            AddServicesActivity(services);
        }
        public static void AddServicesActivity(this IServiceCollection services)
        {
            services.AddScoped<IAddActivityService, AddActivityService>();
            services.AddScoped<ICompleteActivityService, CompleteActivityService>();
            services.AddScoped<IDeleteActivityService, DeleteActivityService>();
            services.AddScoped<IGetAllActivityService, GetAllActivityService>();
            services.AddScoped<IGetByIdActivityService, GetByIdActivityService>();
            services.AddScoped<IMultiplesDeleteActivityService, MultiplesDeleteActivityService>();
            services.AddScoped<IUpdateActivityService, UpdateActivityService>();
        }
    }
}
