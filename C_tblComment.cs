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
    
    public partial class C_tblComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_tblComment()
        {
            this.C_tblthread = new HashSet<C_tblthread>();
        }
    
        public int CommentId { get; set; }
        public System.DateTime Date { get; set; }
        public string FullName { get; set; }
        public string Report { get; set; }
        public int UserId { get; set; }
        public int Roles { get; set; }
        public int RequestId { get; set; }
    
        public virtual C_tblRequest C_tblRequest { get; set; }
        public virtual C_tblUser C_tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_tblthread> C_tblthread { get; set; }
    }
}