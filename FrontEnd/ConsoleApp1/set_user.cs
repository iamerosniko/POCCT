//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class set_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public set_user()
        {
            this.CTD_Calls = new HashSet<CTD_Calls>();
        }
    
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_last_name { get; set; }
        public string user_first_name { get; set; }
        public string user_middle_name { get; set; }
        public Nullable<bool> can_PROD { get; set; }
        public Nullable<bool> can_UAT { get; set; }
        public Nullable<bool> can_PEER { get; set; }
        public Nullable<bool> can_DEV { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTD_Calls> CTD_Calls { get; set; }
    }
}