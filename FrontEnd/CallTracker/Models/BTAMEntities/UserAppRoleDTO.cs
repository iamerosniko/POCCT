using System.Collections.Generic;

namespace CallTracker.Models.BTAMEntities
{
    public class UserAppRoleDTO
    {
        public int UserAppID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleID { get; set; }
        public string Role { get; set; }
        public List<ServiceDTO> services { get; set; }
    }
}
