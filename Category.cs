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
    
    public partial class Category
    {
        public int categoryID { get; set; }
        public System.DateTime dateAdded { get; set; }
        public string description { get; set; }
        public short isDeleted { get; set; }
        public short enabled { get; set; }
        public string name { get; set; }
        public string occupation { get; set; }
        public Nullable<int> parentCategoryID { get; set; }
        public string type { get; set; }
    }
}
