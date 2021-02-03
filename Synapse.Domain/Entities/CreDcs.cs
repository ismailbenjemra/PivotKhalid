using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class CreDcs:EntityBase
    {
        
        //a completer
        
        
        public string LIGNE_SEG { get; set; }
        public string SIRET_PR { get; set; }
        public decimal MT_TOT { get; set; }
        public string CONT_PR { get; set; }
        public string CONT_DG { get; set; }
        public string SIRET_SOUS { get; set; }
        public string RAIS_SOC_A { get; set; }
        public string RAIS_SOC_B { get; set; }
        public string REF_DES_C { get; set; }
        public string ADRESSE { get; set; }
        public decimal MT_DEMAND { get; set; }
        public FluxFile FluxFile { get; set; }
    }
}
