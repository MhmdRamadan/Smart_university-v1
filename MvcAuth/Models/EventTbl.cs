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
    
    public partial class EventTbl
    {
        public int Event_ID { get; set; }
        public string Event_Name { get; set; }
        public string Event_Content { get; set; }
        public Nullable<int> Admin_ID { get; set; }
    
        public virtual AdminTbl AdminTbl { get; set; }
    }
}
