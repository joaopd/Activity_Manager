using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class DataConfigure
    {
        public static void AddDataConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(
                options => options.UseSqlite(configuration.GetConnectionString("Defaut"))
                );
        }
    }
}
