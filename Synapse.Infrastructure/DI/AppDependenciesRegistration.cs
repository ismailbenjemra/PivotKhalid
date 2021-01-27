using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Synapse.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Infrastructure.DI
{
    public class AppDependenciesRegistration
    {
        public static void RegisterAll(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<SynapseDBContext>(options => options.UseSqlServer(@"Data Source=DESKTOP-OE8AEG7\SQLEXPRESS;Initial Catalog=SynapseDb;Integrated Security=True"));
              
        }
    }
}
