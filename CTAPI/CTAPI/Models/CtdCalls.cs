using System;
using System.Collections.Generic;

namespace CTAPI.Models
{
    public partial class CtdCalls
    {
        public int CallId { get; set; }
        public string CallerPhone { get; set; }
        public int CallerAssocId { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfCall { get; set; }
        public int CallStatusId { get; set; }
        public int CallCategoryId { get; set; }

        public CtdCallCategories CallCategory { get; set; }
        public CtdCallStatuses CallStatus { get; set; }
        public CtdCallerAssocs CallerAssoc { get; set; }
        public SetUser UserNameNavigation { get; set; }
    }
}
