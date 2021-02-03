using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class CreAds : AdsCommun
    {
        public string TYPE_GR_RSQ { get; set; }
        public string TYPE_RSQ { get; set; }
        public string NAT_PREST { get; set; }
        public decimal MNT { get; set; }
        public FluxFile FluxFile { get; set; }
        public ICollection<SsaAds> ListSsa { get; set; }
    }
}
