//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Training
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_tblRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_tblRole()
        {
            this.C_tblRequest = new HashSet<C_tblRequest>();
            this.C_tblthread = new HashSet<C_tblthread>();
        }
    
        public int RoleId { get; set; }
        public string RoleType { get; set; }
        public Nullable<int> ThreadId { get; set; }
        public Nullable<int> RequestId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_tblRequest> C_tblRequest { get; set; }
        public virtual C_tblRole C_tblRole1 { get; set; }
        public virtual C_tblRole C_tblRole2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_tblthread> C_tblthread { get; set; }
    }
}
