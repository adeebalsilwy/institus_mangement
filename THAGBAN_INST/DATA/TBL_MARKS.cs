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
    
    public partial class TBL_MARKS
    {
        public int MARK_ID { get; set; }
        public double MARK_COURS { get; set; }
        public Nullable<int> COURS_ID { get; set; }
        public Nullable<int> STUD_ID { get; set; }
        public Nullable<System.DateTime> MARK_YEAR { get; set; }
        public Nullable<int> SPEC_ID { get; set; }
    
        public virtual TBL_COURS TBL_COURS { get; set; }
        public virtual TBL_SPECIAL TBL_SPECIAL { get; set; }
        public virtual TBL_STUDENTS TBL_STUDENTS { get; set; }
    }
}
