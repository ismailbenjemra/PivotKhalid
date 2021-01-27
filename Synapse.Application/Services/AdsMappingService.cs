
using Microsoft.Extensions.Logging;
using Synapse.Application;
using Synapse.Domain;
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
        private readonly IRepository<Cre> _creRepository;

       public AdsMappingService(ILogger<AdsMappingService> logger, IRepository<Cre> creRepository)
        {
            _logger = logger;
            _creRepository = creRepository;
        }

        public List<Cre> GetCommandsFromFile(string filePath)
        {
            try
            {
                //recuperation du fichier sans header avec separateur ";"
                CsvParserOptions csvParserOptions = new CsvParserOptions(false, ';');

                var csvParser = new CsvParser<CsvRecordLigne>(csvParserOptions, new CsvRecordLigneMapping());
                var records = csvParser.ReadFromFile(filePath, Encoding.UTF8).ToList();

                //constitue la liste des Flux du fichier
                var listeCommandes = new List<Cre>();
                foreach (var record in records)
                {
                    if (record.Result.SEG.ToUpper() == "SSA")
                    {
                        continue;
                    }
                    var creWithSsa = Mapper.Map<Cre>(record.Result);
                    creWithSsa.ListSsa = records.Where(r => r.Result.SEG.ToUpper() == "SSA" && r.Result.Col26 == record.Result.NUM_SEG)
                        .Select(r => Mapper.Map<Ssa>(r.Result)).ToList();
                    listeCommandes.Add(creWithSsa);
                }
                return listeCommandes;
            }
            catch
            {
                return new List<Cre>();
            }
        }



        public async Task<int> InsertCreInDb(IEnumerable<Cre> listeCreAds,CancellationToken cancellationToken =default)
        {

            await _creRepository.AddRangeAsync(listeCreAds, cancellationToken);
            return await _creRepository.SaveAsync();


        }


    }
}
