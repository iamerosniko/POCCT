using System.Collections.Generic;

namespace CallTracker.Models.BTAMEntities
{
    public class ServiceDTO
    {
        public int RoleServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }
        public List<AttributesDTO> Attributes { get; set; }
    }
}
