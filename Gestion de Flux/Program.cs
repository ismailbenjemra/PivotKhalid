using AutoMapper;
using CsvHelper;
using Gestion_de_Flux.Mapping;
using Gestion_de_Flux.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TinyCsvParser;

namespace Gestion_de_Flux
{
    class Program
    {
        static void Main(string[] args)
        {
            // the app is starting here
            AutoMapperInitializer.Initialize();

            var listeCommandes = GetCommandsFromFile(@"C:\Users\ismai\Desktop\FluxGestion\PivotKhalid\Fluuux\PRDG_ADS_SANTE_210108.csv");

            //Executer le traitement de verification 

            //Stocage Output

            Console.WriteLine("Hello World!");
        }

        private static List<CreWithSSA> GetCommandsFromFile(string filePath)
        {
            try
            {
                //recuperation du fichier sans header avec separateur ";"
                CsvParserOptions csvParserOptions = new CsvParserOptions(false, ';');

                var csvParser = new CsvParser<CsvRecordLigne>(csvParserOptions, new CsvRecordLigneMapping());
                var records = csvParser.ReadFromFile(filePath, Encoding.UTF8).ToList();

                //constitue la liste des Flux du fichier
                var listeCommandes = new List<CreWithSSA>();
                foreach (var record in records)
                {
                    if (record.Result.SEG.ToUpper() == "SSA")
                    {
                        continue;
                    }

                    var creWithSsa = new CreWithSSA()
                    {
                        cre = Mapper.Map<Cre>(record.Result),
                        ListSSA = records.Where(r => r.Result.SEG.ToUpper() == "SSA" && r.Result.Col26 == record.Result.NUM_SEG)
                        .Select(r => Mapper.Map<Ssa>(r.Result)).ToList()
                    };
                    listeCommandes.Add(creWithSsa);
                }
                return listeCommandes;
            }
            catch
            {
                return new List<CreWithSSA>();
            }
        }
    }
}
