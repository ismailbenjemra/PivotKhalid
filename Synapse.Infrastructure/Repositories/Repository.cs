
using EFCoreBulk;
using EntityFramework.Utilities;
using Synapse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Synapse.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public SynapseDBContext context { get; }

        public Repository(SynapseDBContext context)
        {
            this.context = context;
        }
      

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
           var newTemperatureHistory = await context.Set<T>().AddAsync(entity, cancellationToken).ConfigureAwait(false);
            return newTemperatureHistory.Entity;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            this.context.ChangeTracker.AutoDetectChangesEnabled = false;
            return await this.context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
        
            await context.Set<T>().AddRangeAsync(entities, cancellationToken).ConfigureAwait(false);
        }

        public Task AddAsync(FluxFile fluxFile, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
