//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointerSecurity_Azure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buildings
    {
        public Buildings()
        {
            this.Apartment = new HashSet<Apartment>();
            this.PendingModules = new HashSet<PendingModules>();
            this.ManagerBuilding = new HashSet<ManagerBuilding>();
            this.UserActivityLog = new HashSet<UserActivityLog>();
        }
    
        public int ID { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public Nullable<int> NumberOfApartment { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string BuildingPhone { get; set; }
        public string Manager { get; set; }
        public string ManagersID { get; set; }
    
        public virtual ICollection<Apartment> Apartment { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Manager Manager1 { get; set; }
        public virtual ICollection<PendingModules> PendingModules { get; set; }
        public virtual ICollection<ManagerBuilding> ManagerBuilding { get; set; }
        public virtual ICollection<UserActivityLog> UserActivityLog { get; set; }
    }
}
