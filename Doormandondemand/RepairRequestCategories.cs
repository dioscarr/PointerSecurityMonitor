//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doormandondemand
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepairRequestCategories
    {
        public RepairRequestCategories()
        {
            this.RepairRequest = new HashSet<RepairRequest>();
        }
    
        public int Id { get; set; }
        public string Categories { get; set; }
        public int BuildingID { get; set; }
    
        public virtual Buildings Buildings { get; set; }
        public virtual ICollection<RepairRequest> RepairRequest { get; set; }
    }
}