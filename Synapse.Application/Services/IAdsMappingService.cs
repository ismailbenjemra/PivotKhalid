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
       
        List<CreAds> GetCommandsFromFile(string filePath);

        Task<int> InsertCreInDb(IEnumerable<CreAds> listeCreAds, CancellationToken cancellationToken = default);

        Task<int> InsertFileInDb(FluxFile fluxFile, CancellationToken cancellationToken = default);

        
    }
}