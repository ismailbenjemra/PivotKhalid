using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class ReservoirAccapulco:EntityBase
    {
        public DateTime DateSaisie { get; set; }
        public string Matricule_Apporteur_Gest { get; set; }
        public string Numero_Ordre { get; set; }
        public string Numero_Bordereau { get; set; }

        public ICollection<PrestationCommune> PrestationCommunes { get; set; }
        public Etat_Prestation Etat_Prestation { get; set; }
    }
}
