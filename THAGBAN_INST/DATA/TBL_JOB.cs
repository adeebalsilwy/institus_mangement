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
    
    public partial class TBL_JOB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_JOB()
        {
            this.TBL_EMPLOYEES = new HashSet<TBL_EMPLOYEES>();
        }
    
        public int JOB_ID { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_DESC { get; set; }
        public string NOTE { get; set; }
        public Nullable<int> DEPT_ID { get; set; }
    
        public virtual TBL_DEPT TBL_DEPT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_EMPLOYEES> TBL_EMPLOYEES { get; set; }
    }
}
