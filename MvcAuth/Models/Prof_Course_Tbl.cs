//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAuth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prof_Course_Tbl
    {
        public int ID { get; set; }
        public Nullable<int> Prof_ID { get; set; }
        public Nullable<int> Course_ID { get; set; }
    
        public virtual CourseTbl CourseTbl { get; set; }
        public virtual ProfessorTbl ProfessorTbl { get; set; }
    }
}
