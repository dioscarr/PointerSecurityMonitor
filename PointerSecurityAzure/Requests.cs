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
    
    public partial class Requests
    {
        public int ID { get; set; }
        public string RequestType { get; set; }
        public string Description { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public string PIN { get; set; }
        public string TenantID { get; set; }
    
        public virtual Tenant Tenant { get; set; }
    }
}
