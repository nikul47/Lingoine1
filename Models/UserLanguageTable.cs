//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lingoine1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLanguageTable
    {
        public string UserEmailId { get; set; }
        public int LanguageId { get; set; }
        public int ProficiencyLevel { get; set; }
        public double Rating { get; set; }
        public int NumOfCalls { get; set; }
    
        public virtual LanguageTable LanguageTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
