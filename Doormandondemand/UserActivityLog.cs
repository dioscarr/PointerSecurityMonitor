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
    
    public partial class UserActivityLog
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public Nullable<int> BuildingID { get; set; }
        public string FunctionPerformed { get; set; }
        public System.DateTime DateOfEvent { get; set; }
        public string Message { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Buildings Buildings { get; set; }
    }
}
