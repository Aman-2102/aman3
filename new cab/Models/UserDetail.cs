//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace new_cab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserDetail()
        {
            this.logindetails = new HashSet<logindetail>();
            this.UserDrives = new HashSet<UserDrive>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public Nullable<int> WalletAmount { get; set; }
        public Nullable<int> usertype { get; set; }
        public string phoneNumber { get; set; }
        public string useremail { get; set; }
        public string userpass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<logindetail> logindetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDrive> UserDrives { get; set; }
    }
}