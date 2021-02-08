using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                using (var scope = _service.CreateScope())
                {
                // Création du chronomètre.
                Stopwatch stopwatch = new Stopwatch();

                // Démarrage du chronomètre.
                stopwatch.Start();
                var _adsMappingService = scope.ServiceProvider.GetRequiredService<IAdsMappingService>();
                var listAdsPrestations = _adsMappingService.GetCommandsFromFile(@"C:\Users\ismai\Desktop\FluxGestion\PivotKhalid\Fluuux\PRDG_ADS_SANTE_210108.csv");
                int affectedLignes = await _adsMappingService.InsertCreInDb(listAdsPrestations);
               // await _adsMappingService.InsertCreInDeAsync(listAdsPrestations);
                

                // Arrêt du chronomètre.
                stopwatch.Stop();
                Console.WriteLine("Durée d'exécution: {0}", stopwatch.Elapsed.TotalSeconds);


                // IHM.


            }

        }
    }
}
