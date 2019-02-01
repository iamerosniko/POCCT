using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallTracker.Models.DTO
{
    public class CTDCalls_DTO
    {
        public int CallID { get; set; }
        public string CallerPhone { get; set; }
        public int CallerAssocID { get; set; }
        public string CallerAssoc { get; set; }
        public string user_name { get; set; }
        public DateTime DateOfCall { get; set; }
        public int CallStatusID { get; set; }
        public string CallStatus { get; set; }
        public int CallCategoryID { get; set; }
        public string CallCategory { get; set; }
        public bool IsSaved { get; set; }
    }
}
