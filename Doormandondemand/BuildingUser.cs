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
    
    public partial class BuildingUser
    {
        public BuildingUser()
        {
            this.RepairRequest = new HashSet<RepairRequest>();
        }
    
        public string Id { get; set; }
        public int BuildingID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string UserID { get; set; }
        public string Skill { get; set; }
    
        public virtual Buildings Buildings { get; set; }
        public virtual ICollection<RepairRequest> RepairRequest { get; set; }
    }
}
