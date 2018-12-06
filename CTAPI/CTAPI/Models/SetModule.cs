using System;
using System.Collections.Generic;

namespace CTAPI.Models
{
    public partial class SetModule
    {
        public string ModId { get; set; }
        public string ModName { get; set; }
        public string ModDesc { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
