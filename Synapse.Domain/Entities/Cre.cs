using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class Cre : AdsCommun
    {
        public string TYPE_GR_RSQ { get; set; }
        public string TYPE_RSQ { get; set; }
        public string NAT_PREST { get; set; }
        public string MNT { get; set; }
        public ICollection<Ssa> ListSsa { get; set; }
    }
}
