using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class PrestationCommune:EntityBase
    {
        /// <summary>
        /// Ajout commentaire
        /// </summary>
        public string REF_PR { get; set; }
        public string EXR_SURV { get; set; }
        public decimal MT_PREST_DG { get; set; }
        public string MOIS_SURV { get; set; }
        public string PER_DEB { get; set; }
        public string PER_FIN { get; set; }
        public CreAds CreAds { get; set; }
        public CreDcs CreDcs { get; set; }
        public ReservoirAccapulco ReservoirAccapPivot { get; set; }
        public Etat_Prestation Etat_Prestation { get; set; }

    }
}
