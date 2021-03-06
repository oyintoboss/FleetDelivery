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
    
    public partial class C_tblRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_tblRequest()
        {
            this.C_tblComment = new HashSet<C_tblComment>();
            this.C_tblthread = new HashSet<C_tblthread>();
        }
    
        public int RequestId { get; set; }
        public int RoleTo { get; set; }
        public int RoleThru { get; set; }
        public string Unit { get; set; }
        public System.DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Report { get; set; }
        public string Attachment { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Vehicle { get; set; }
        public string Site { get; set; }
        public int RoleId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_tblComment> C_tblComment { get; set; }
        public virtual C_tblRole C_tblRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_tblthread> C_tblthread { get; set; }
    }
}
