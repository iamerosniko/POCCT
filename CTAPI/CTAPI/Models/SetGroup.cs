using System;
using System.Collections.Generic;

namespace CTAPI.Models
{
    public partial class SetGroup
    {
        public string GrpId { get; set; }
        public string GrpName { get; set; }
        public string GrpDesc { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
