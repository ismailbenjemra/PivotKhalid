using Synapse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Application.Models
{
    public class CreWithSSA
    {
        public Cre cre { get; set; }
        public List<Ssa> ListSSA { get; set; }
    }
}
