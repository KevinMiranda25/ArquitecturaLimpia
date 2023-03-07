using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using KevinMiranda.ArqLimpia.EN.Interfaces;

namespace KevinMiranda.ArqLimpia.DAL
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KevinMirandaDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("conexion")));

            services.AddScoped<IUser, UserDAL>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
