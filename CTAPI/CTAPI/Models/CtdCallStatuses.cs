using System;
using System.Collections.Generic;

namespace CTAPI.Models
{
    public partial class CtdCallStatuses
    {
        public CtdCallStatuses()
        {
            CtdCalls = new HashSet<CtdCalls>();
        }

        public int CallStatusId { get; set; }
        public string CallStatusDesc { get; set; }
        public bool? Active { get; set; }

        public ICollection<CtdCalls> CtdCalls { get; set; }
    }
}
