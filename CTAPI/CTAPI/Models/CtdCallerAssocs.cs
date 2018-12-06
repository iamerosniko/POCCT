using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CTAPI.Models
{
    public partial class CtdCallerAssocs
    {
        public CtdCallerAssocs()
        {
            CtdCalls = new HashSet<CtdCalls>();
        }
        [Key]
        public int CallerAssocId { get; set; }
        public string CallerAssocDesc { get; set; }
        public bool? Active { get; set; }

        public ICollection<CtdCalls> CtdCalls { get; set; }
    }
}
