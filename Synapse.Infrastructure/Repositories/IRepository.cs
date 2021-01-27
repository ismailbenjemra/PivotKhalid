using Synapse.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Synapse.Infrastructure.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);




    }
}