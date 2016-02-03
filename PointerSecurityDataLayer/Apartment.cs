//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointerSecurityDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        public Apartment()
        {
            this.Shipment = new HashSet<Shipment>();
            this.Tenant = new HashSet<Tenant>();
        }
    
        public int ID { get; set; }
        public string ApartmentNumber { get; set; }
        public string FloorNumber { get; set; }
        public Nullable<int> BuildingID { get; set; }
    
        public virtual Buildings Buildings { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
        public virtual ICollection<Tenant> Tenant { get; set; }
    }
}
