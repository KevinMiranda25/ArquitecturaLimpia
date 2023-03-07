using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KevinMiranda.ArqLimpia.DAL;
using KevinMiranda.ArqLimpia.BL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace KevinMiranda.ArqLimpia.IoC
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddESFEDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddBLDependecies();
            return services;
        }
    }
}
