using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Implementation.SqlServer
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterDataAccess(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<BookSystemContext>(opts => 
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
            return services;
        }
    }
}
