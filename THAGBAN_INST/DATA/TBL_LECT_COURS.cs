//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THAGBAN_INST.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_LECT_COURS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_LECT_COURS()
        {
            this.TBL_LECT_MARK = new HashSet<TBL_LECT_MARK>();
            this.TBL_LECT_MATRIAL = new HashSet<TBL_LECT_MATRIAL>();
            this.TBL_LECTUER = new HashSet<TBL_LECTUER>();
        }
    
        public int LECT_COURS_ID { get; set; }
        public string LECT_COURS_NAME { get; set; }
        public string LECT_COURS_DESC { get; set; }
        public Nullable<bool> LECT_COURS_STATE { get; set; }
        public Nullable<System.DateTime> LECT_COURS_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_LECT_MARK> TBL_LECT_MARK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_LECT_MATRIAL> TBL_LECT_MATRIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_LECTUER> TBL_LECTUER { get; set; }
    }
}