using Synapse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Application.Models
{
    public class CreWithSSA
    {
        public CreAds cre { get; set; }
        public List<SsaAds> ListSSA { get; set; }
    }
}
