//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjaxCab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDrive
    {
        public int UserDriveMappingId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PickupLocationId { get; set; }
        public Nullable<int> DropLocationId { get; set; }
    
        public virtual locationoption locationoption { get; set; }
        public virtual locationoption locationoption1 { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
