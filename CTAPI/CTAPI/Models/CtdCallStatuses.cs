using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTAPI.Models
{
    [Table("CTD_CallStatuses")]
    public partial class CtdCallStatuses
    {
        [Key]
        public int CallStatusID { get; set; }
        public string CallStatusDesc { get; set; }
        public bool? Active { get; set; }
    }
}
