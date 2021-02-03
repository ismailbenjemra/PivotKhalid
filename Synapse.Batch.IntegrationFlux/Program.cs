using Microsoft.Extensions.DependencyInjection;
using Synapse.Application.Services;

namespace Synapse.Batch.IntegrationFlux
{
    class Program
    {
        static void Main(string[] args)
        {
            var _adsMappingService = ServiceProvider.GetRequiredService<IAdsMappingService>();
            var listAdsPrestations = _adsMappingService.GetCommandsFromFile(@"C:\Users\ismai\Desktop\FluxGestion\PivotKhalid\Fluuux\PRDG_ADS_SANTE_210108.csv");
            
        }
    }
}
