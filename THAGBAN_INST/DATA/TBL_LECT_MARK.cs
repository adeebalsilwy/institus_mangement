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
    
    public partial class TBL_LECT_MARK
    {
        public int MARK_ID { get; set; }
        public Nullable<double> MARK_VALUE { get; set; }
        public Nullable<int> MATRIAL_ID { get; set; }
        public Nullable<int> LECT_ID { get; set; }
        public Nullable<int> COURS_ID { get; set; }
        public Nullable<int> LECT_TECH_ID { get; set; }
        public Nullable<int> STUD_ID { get; set; }
        public Nullable<int> LECT_STUD_ID { get; set; }
    
        public virtual TBL_LECT_COURS TBL_LECT_COURS { get; set; }
        public virtual TBL_LECT_MATRIAL TBL_LECT_MATRIAL { get; set; }
        public virtual TBL_LECT_TECH_COURS TBL_LECT_TECH_COURS { get; set; }
        public virtual TBL_LECTUER TBL_LECTUER { get; set; }
        public virtual TBL_STUD_LECT TBL_STUD_LECT { get; set; }
        public virtual TBL_STUDENTS TBL_STUDENTS { get; set; }
    }
}
