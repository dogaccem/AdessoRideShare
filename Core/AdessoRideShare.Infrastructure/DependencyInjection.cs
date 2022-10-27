using AdessoRideShare.Application.Abstractions.Repositories;
using AdessoRideShare.Infrastructure.Persistence.Contexts;
using AdessoRideShare.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdessoRideShare.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlServerConnectionString = configuration.GetConnectionString("SqlServerDbConnection");

            //Add repositories
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IRouteRepository, RouteRepository>();

            services.AddDbContext<AdessoRideShareAppDbContext>(options =>
                options.UseSqlServer(sqlServerConnectionString));


            return services;
        }

    }
}
