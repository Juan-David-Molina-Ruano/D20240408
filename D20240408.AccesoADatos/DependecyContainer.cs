using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20240408.AccesoADatos
{
    public static class DependecyContainer
    {
        public static IServiceCollection addAddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<PersonaDDAL>();

            return services;
        }
    }
}
