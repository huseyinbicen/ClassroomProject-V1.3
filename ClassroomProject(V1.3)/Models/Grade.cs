//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassroomProject_V1._3_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int Id { get; set; }
        public Nullable<int> Student_Id { get; set; }
        public string Name { get; set; }
        public string Mark { get; set; }
        public string Ranking { get; set; }
    
        public virtual Student Student { get; set; }
    }
}