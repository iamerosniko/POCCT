using System;
using System.Collections.Generic;

namespace CTAPI.Models
{
    public partial class SetUser
    {
        public SetUser()
        {
            CtdCalls = new HashSet<CtdCalls>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserFirstName { get; set; }
        public string UserMiddleName { get; set; }
        public bool? CanProd { get; set; }
        public bool? CanUat { get; set; }
        public bool? CanPeer { get; set; }
        public bool? CanDev { get; set; }
        public DateTime? CreatedDate { get; set; }

        public ICollection<CtdCalls> CtdCalls { get; set; }
    }
}
