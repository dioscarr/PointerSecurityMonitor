//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointerSecurityAzure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tenant
    {
        public Tenant()
        {
            this.Requests = new HashSet<Requests>();
        }
    
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public System.DateTime Created { get; set; }
        public string isTemPWord { get; set; }
        public Nullable<int> aptID { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
