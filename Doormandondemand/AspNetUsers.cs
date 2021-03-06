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
    
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaims>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogins>();
            this.BuildingUserMapping = new HashSet<BuildingUserMapping>();
            this.PermissionMapRole = new HashSet<PermissionMapRole>();
            this.Role = new HashSet<Role>();
            this.Shipment = new HashSet<Shipment>();
            this.UserActivityLog = new HashSet<UserActivityLog>();
            this.AspNetRoles = new HashSet<AspNetRoles>();
        }
    
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
    
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<BuildingUserMapping> BuildingUserMapping { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual ICollection<PermissionMapRole> PermissionMapRole { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<UserActivityLog> UserActivityLog { get; set; }
        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }
        public virtual Contractor Contractor { get; set; }
    }
}
