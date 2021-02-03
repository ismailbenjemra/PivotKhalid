using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Domain.Entities
{
    public class History : EntityBase
    {

        public string TableName { get; set; }
        public Guid UpdateGroup { get; set; }
        public string KeyValues { get; set; } //id de la ligne modifier
        public string ColonneName { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
