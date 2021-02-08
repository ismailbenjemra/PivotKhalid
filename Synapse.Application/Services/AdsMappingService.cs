
using Microsoft.Extensions.Logging;
using Synapse.Infrastructure.Repositories;
using Synapse.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TinyCsvParser;
using System.Text;
using Synapse.Application.Mapping;
using AutoMapper;
using Synapse.Domain.Entities;

namespace Synapse.Application.Services
{
    public class AdsMappingService : IAdsMappingService
    {

        private readonly ILogger<AdsMappingService> _logger;
        private readonly IRepository<CreAds> _creRepository;

        public AdsMappingService(ILogger<AdsMappingService> logger, IRepository<CreAds> creRepository)
        {
            _logger = logger;
            _creRepository = creRepository;
        }

        public List<CreAds> GetCommandsFromFile(string filePath)
        {
            try
            {
                //recuperation du fichier sans header avec separateur ";"
                CsvParserOptions csvParserOptions = new CsvParserOptions(false, ';');

                var csvParser = new CsvParser<CsvRecordLigne>(csvParserOptions, new CsvRecordLigneMapping());
                var records = csvParser.ReadFromFile(filePath, Encoding.UTF8).ToList();

                //constitue la liste des Flux du fichier
                var listeCommandes = new List<CreAds>();
                foreach (var record in records)
                {
                    if (record.Result.SEG.ToUpper() == "SSA")
                    {
                        continue;
                    }
                    var creWithSsa = Mapper.Map<CreAds>(record.Result);
                    creWithSsa.ListSsa = records.Where(r => r.Result.SEG.ToUpper() == "SSA" && r.Result.Col26 == record.Result.NUM_SEG)
                        .Select(r => Mapper.Map<SsaAds>(r.Result)).ToList();
                    listeCommandes.Add(creWithSsa);
                }
                return listeCommandes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message.ToString());
                return new List<CreAds>();
            }
        }

        /*
          
         
         */


        public async Task<int> InsertCreInDb(IEnumerable<CreAds> listeCreAds, CancellationToken cancellationToken = default)
        {
          
            await _creRepository.AddRangeAsync(listeCreAds, cancellationToken);
            return await _creRepository.SaveAsync();
        }

        public async Task InsertCreInDeAsync(IEnumerable<CreAds> listeCreAds, CancellationToken cancellationToken = default)
        {

            var listCount = listeCreAds.Count();
            var step = 550;
            for (int i = 0; i < listCount; i += step)
            {
                var newlist = listeCreAds.Skip(i).Take(step);
                await _creRepository.AddRangeAsync(newlist);
                await _creRepository.SaveAsync();


            }


        }


        public async Task<int> InsertFileInDb(FluxFile fluxFile, CancellationToken cancellationToken = default)
        {



            await _creRepository.AddAsync(fluxFile, cancellationToken);
            return await _creRepository.SaveAsync();
        }


    }
}
