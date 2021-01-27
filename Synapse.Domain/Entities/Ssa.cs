using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class Ssa : AdsCommun
    {
        public string SEG_SSA { get; set; } // a modifier dans Excel en numerique
        public string TYPE_GR_RSQ { get; set; }
        public string TYPE_RSQ { get; set; }
        public string NAT_PREST { get; set; }
        public string CD_RSQ { get; set; }
        public string NATEVT { get; set; }
        public string CD_EVT { get; set; }
        public string CD_DG_EVT { get; set; } 
        public string COT_ASSUR { get; set; }
        public string TR_AGE { get; set; }
        public string SEX_ASSUR { get; set; }
        public string CAT_ASSUR { get; set; }
        public string MOIS_SURV { get; set; }
        public string CD_PREST { get; set; }
        public string NB_ACTE { get; set; } 
        public string CD_DVS { get; set; }
        public string MT_FRA_REEL { get; set; }
        public string MT_PREST_DG { get; set; }
        public string MT_RMB_SS { get; set; }
        public string MT_AUT_RMB { get; set; }
        public string CD_SEQ { get; set; }
        public string NB_ASSUR { get; set; }
        public string MT_AKT_MAX { get; set; }
        public string TX_RMB_SCS    { get; set; }
        public string BASE_RMB_SCS    { get; set; }
        public string CD_DVS_REEL    { get; set; }
        public string CD_DVS_RMB_SCS    { get; set; }
        public string CD_DVS_RMB_AUT { get; set; }

        public Cre Cre { get; set; }

    }
}
