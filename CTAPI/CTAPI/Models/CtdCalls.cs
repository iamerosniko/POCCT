using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTAPI.Models
{
    [Table("CTD_Calls")]
    public class CtdCalls
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CallID { get; set; }
        public string CallerPhone { get; set; }
        public int CallerAssocID { get; set; }
        public string user_name { get; set; }
        public DateTime DateOfCall { get; set; }
        public int CallStatusID { get; set; }
        public int CallCategoryID { get; set; }

    }
}
