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
    
    public partial class locationoption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public locationoption()
        {
            this.UserDrives = new HashSet<UserDrive>();
            this.UserDrives1 = new HashSet<UserDrive>();
        }
    
        public int optionId { get; set; }
        public string insideLocationName { get; set; }
        public Nullable<int> locationMappingid { get; set; }
    
        public virtual locationTable locationTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDrive> UserDrives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDrive> UserDrives1 { get; set; }
    }
}
