//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EngineersMatrimony.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interest
    {
        public int IntID { get; set; }
        public Nullable<int> FromId { get; set; }
        public Nullable<int> ToId { get; set; }
        public Nullable<int> MatchScore { get; set; }
        public int Status { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
    }
}
