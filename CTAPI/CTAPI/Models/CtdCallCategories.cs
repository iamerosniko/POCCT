using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTAPI.Models
{
    [Table("CTD_CallCategories")]
    public partial class CtdCallCategories
    {
        public CtdCallCategories()
        {
            CtdCalls = new HashSet<CtdCalls>();
        }
        [Key]
        public int CallCategoryId { get; set; }
        public string CallCategoryDesc { get; set; }
        public bool? Active { get; set; }

        public ICollection<CtdCalls> CtdCalls { get; set; }
    }
}
