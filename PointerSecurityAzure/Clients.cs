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
    
    public partial class Clients
    {
        public Clients()
        {
            this.Buildings = new HashSet<Buildings>();
            this.Manager = new HashSet<Manager>();
        }
    
        public int ID { get; set; }
        public string ClientName { get; set; }
        public Nullable<int> BuildingCount { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    
        public virtual ICollection<Buildings> Buildings { get; set; }
        public virtual ICollection<Manager> Manager { get; set; }
    }
}
