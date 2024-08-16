using Business.Abstraction;
using Business.Abstraction.Services;
using Business.Repositories;
using Business.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class ServiceRegistiration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IDeviceRepositories, DeviceRepositories>();
            services.AddScoped<IPingRepositories, PingRepositories>();
            services.AddScoped<IPingService, PingService>();

        }
    }
}
