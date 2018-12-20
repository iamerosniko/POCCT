using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTAPI.Models
{
    [Table("CTD_CallCategories")]
    public class CtdCallCategories
    {
        [Key]
        public int CallCategoryID { get; set; }
        public string CallCategoryDesc { get; set; }
        public bool? Active { get; set; }
    }
}
