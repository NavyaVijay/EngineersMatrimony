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
    
    public partial class Profile
    {
        
        public int RegID { get; set; }
        public Nullable<int> MID { get; set; }
        public string PName { get; set; }
        public string Email { get; set; }
        public System.DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
        public string Gender { get; set; }
        public string District { get; set; }
        public Nullable<double> Height { get; set; }
        public Nullable<double> Weight { get; set; }
        public string Occupation { get; set; }
        public string MStatus { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string FamilyType { get; set; }
        public Nullable<double> AnnualIncome { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
