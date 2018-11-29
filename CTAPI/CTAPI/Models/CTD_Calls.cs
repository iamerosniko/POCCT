using System;

namespace CTAPI.Models
{
    public class CTD_Calls
    {
        public int CallID { get; set; }
        public string CallerPhone { get; set; }
        public int CallerAssocID { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfCall { get; set; }
        public int CallStatusID { get; set; }
        public int CallCategoryID { get; set; }
    }
}
