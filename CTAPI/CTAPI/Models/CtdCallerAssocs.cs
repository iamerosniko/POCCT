using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTAPI.Models
{
    [Table("CTD_CallerAssocs")]
    public class CtdCallerAssocs
    {
        [Key]
        public int CallerAssocID { get; set; }
        public string CallerAssocDesc { get; set; }
        public bool? Active { get; set; }
    }
}
