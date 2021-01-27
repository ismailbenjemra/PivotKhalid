using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Synapse.Application.Services;

namespace Synapse.Batch.FluxIntegration
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _service;

        public Worker(ILogger<Worker> logger, IServiceProvider service)
        {
            _logger = logger;
            _service = service;
           //_adsMappingService = adsMappingService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                using (var scope = _service.CreateScope())
                {
                    var _adsMappingService= scope.ServiceProvider.GetRequiredService<IAdsMappingService>();
                    var listAdsPrestations = _adsMappingService.GetCommandsFromFile(@"C:\Users\ismai\Desktop\FluxGestion\PivotKhalid\Fluuux\PRDG_ADS_SANTE_210108.csv");
                    int affectedLignes=await _adsMappingService.InsertCreInDb(listAdsPrestations);

                }
                   
                
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
