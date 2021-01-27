using Synapse.Application.Models;
using Synapse.Domain;
using Synapse.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Synapse.Application.Services
{
    public interface IAdsMappingService
    {
       
        List<Cre> GetCommandsFromFile(string filePath);

        Task<int> InsertCreInDb(IEnumerable<Cre> listeCreAds, CancellationToken cancellationToken = default);
    }
}