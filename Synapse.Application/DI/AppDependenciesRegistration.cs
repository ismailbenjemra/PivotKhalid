using Microsoft.Extensions.DependencyInjection;
using Synapse.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Synapse.Application.DI
{
    public class AppDependenciesRegistration
    {
        public static void RegisterAll(IServiceCollection services)
        {
            services.AddTransient<IAdsMappingService, AdsMappingService>();
            Infrastructure.DI.AppDependenciesRegistration.RegisterAll(services);

            Infrastructure.DI.AppDependenciesRegistration.RegisterAll(services);
        }
    }
}
