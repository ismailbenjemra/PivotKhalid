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
            // services.AddDbContext<SynapseDBContext>(options => options.UseSqlServer(@"Data Source=DESKTOP-OE8AEG7\SQLEXPRESS;Initial Catalog=SynapseDb;Integrated Security=True"));
            string connStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));Persist Security Info=True;User ID=system;Password=Rani@2020";
            services.AddDbContext<SynapseDBContext>(options => options.UseOracle(connStr));

        }
    }
}
