//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gb_raw.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TFAnswer
    {
        public int answerID { get; set; }
        public bool trueOrFalse { get; set; }
    
        public virtual Answer Answer { get; set; }
    }
}