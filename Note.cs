//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODataService314e
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        public int noteID { get; set; }
        public string action { get; set; }
        public int commentingPersonID { get; set; }
        public string comments { get; set; }
        public System.DateTime dateAdded { get; set; }
        public short isDeleted { get; set; }
        public Nullable<int> minutesSpent { get; set; }
        public int personReferenceID { get; set; }
    }
}
