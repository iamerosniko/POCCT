using System;

namespace BackendConnector.Entities
{
    public class CtdCallsDTO
    {
        public string CallerPhone { get; set; }
        public int CallerAssocID { get; set; }
        public string user_name { get; set; }
        public DateTime DateOfCall { get; set; }
        public int CallStatusID { get; set; }
        public int CallCategoryID { get; set; }

    }
}
