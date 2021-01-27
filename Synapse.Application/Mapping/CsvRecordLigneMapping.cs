using Synapse.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;

namespace Synapse.Application.Mapping
{
   public class CsvRecordLigneMapping:CsvMapping<CsvRecordLigne>
    {
        public CsvRecordLigneMapping() : base()
        {
            MapProperty(0, x => x.SEG);
            MapProperty(1, x => x.NUM_SEG);
            MapProperty(2, x => x.NUM_FICH_BRIDGE);
            MapProperty(3, x => x.NOM_PIVOT); 
            MapProperty(4, x => x.PIVOT_TYPE);
            MapProperty(5, x => x.VERSION);
            MapProperty(6, x => x.DT_FAB);
            MapProperty(7, x => x.NOM_FICH);
            MapProperty(8, x => x.ID_MESS);
            MapProperty(9, x => x.ID_DG);
            MapProperty(10, x => x.NOM_DG);
            MapProperty(11, x => x.ID_PR);
            MapProperty(12, x => x.NOM_PR);
            MapProperty(13, x => x.PER_DEB);
            MapProperty(14, x => x.PER_FIN);
            MapProperty(15, x => x.CONV_REF);
            MapProperty(16, x => x.MNT_TOT);
            MapProperty(17, x => x.REF_PR);
            MapProperty(18, x => x.REF_DG);
            MapProperty(19, x => x.ID_SOUS);
            MapProperty(20, x => x.NOM_SOUS);
            MapProperty(21, x => x.NOM_SOUS_COMP);
            MapProperty(22, x => x.LIB_CNT);
            MapProperty(23, x => x.ADDR_SOUS);
            MapProperty(24, x => x.EXR_SURV);
            MapProperty(25, x => x.Col26);
            MapProperty(26, x => x.Col27);
            MapProperty(27, x => x.Col28);
            MapProperty(28, x => x.Col29);
            MapProperty(29, x => x.CD_RSQ);
            MapProperty(30, x => x.NATEVT);
            MapProperty(31, x => x.CD_EVT);
            MapProperty(32, x => x.CD_DG_EVT);
            MapProperty(33, x => x.COT_ASSUR);
            MapProperty(34, x => x.TR_AGE);
            MapProperty(35, x => x.SEX_ASSUR);
            MapProperty(36, x => x.CAT_ASSUR);
            MapProperty(37, x => x.MOIS_SURV);
            MapProperty(38, x => x.CD_PREST);
            MapProperty(39, x => x.NB_ACTE);
            MapProperty(40, x => x.CD_DVS);
            MapProperty(41, x => x.MT_FRA_REEL);
            MapProperty(42, x => x.MT_PREST_DG);
            MapProperty(43, x => x.MT_RMB_SS);
            MapProperty(44, x => x.MT_AUT_RMB);
            MapProperty(45, x => x.CD_SEQ);
            MapProperty(46, x => x.NB_ASSUR);
            MapProperty(47, x => x.MT_AKT_MAX);
            MapProperty(48, x => x.TX_RMB_SCS);
            MapProperty(49, x => x.BASE_RMB_SCS);
            MapProperty(50, x => x.CD_DVS_REEL);
            MapProperty(51, x => x.CD_DVS_RMB_SCS);
            MapProperty(52, x => x.CD_DVS_RMB_AUT);
        }

    }
}
