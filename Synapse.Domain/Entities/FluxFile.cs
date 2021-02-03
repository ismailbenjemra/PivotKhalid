using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class FluxFile:EntityBase
    {
        public Byte [] File { get; set; }
        public string FileName { get; set; }
        public DateTime ProcessedAt { get; set; }

    }
}
