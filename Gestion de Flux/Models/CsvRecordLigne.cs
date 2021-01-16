using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Flux
{
    public class CsvRecordLigne
    {
        public string SEG { get; set; }
        public string NUM_SEG { get; set; }
        public string NUM_FICH_BRIDGE { get; set; }
        public string NOM_PIVOT { get; set; }
        public string PIVOT_TYPE { get; set; }
        public string VERSION { get; set; }
        public string DT_FAB { get; set; }
        public string NOM_FICH { get; set; }
        public string ID_MESS { get; set; }
        public string ID_DG { get; set; }
        public string NOM_DG { get; set; }
        public string ID_PR { get; set; }
        public string NOM_PR { get; set; }
        public string PER_DEB { get; set; }
        public string PER_FIN { get; set; }
        public string CONV_REF { get; set; }
        public string MNT_TOT { get; set; } //N(2)
        public string REF_PR { get; set; }
        public string REF_DG { get; set; }
        public string ID_SOUS { get; set; }
        public string NOM_SOUS { get; set; }
        public string NOM_SOUS_COMP { get; set; }
        public string LIB_CNT { get; set; }
        public string ADDR_SOUS { get; set; }
        public string EXR_SURV { get; set; }
        //cre proprieties
        public string Col26 { get; set; }
        public string Col27 { get; set; }
        public string Col28 { get; set; }
        public string Col29 { get; set; }

        //SSA properties
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
        public string TX_RMB_SCS { get; set; }
        public string BASE_RMB_SCS { get; set; }
        public string CD_DVS_REEL { get; set; }
        public string CD_DVS_RMB_SCS { get; set; }
        public string CD_DVS_RMB_AUT { get; set; }

    }
}
