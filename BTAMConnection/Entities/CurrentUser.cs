using System.Collections.Generic;

namespace BTAMConnection.Entities
{
    public class CurrentUser
    {
        public int UserAppID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleID { get; set; }
        public string Role { get; set; }
        public List<ServiceDTO> services { get; set; }

        public CurrentUser()
        {
            UserID = "";
            FirstName = "";
            LastName = "";
            Role = "NoAccess";
        }
    }
    public class ServiceDTO
    {
        public int RoleServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }
        public List<AttributesDTO> Attributes { get; set; }
    }
    public class AttributesDTO
    {
        public string AttribName { get; set; }
        public string AttribDesc { get; set; }
    }
}
