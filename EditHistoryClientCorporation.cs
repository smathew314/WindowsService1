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
    
    public partial class EditHistoryClientCorporation
    {
        public int editHistoryClientCorporationID { get; set; }
        public int clientCorporationID { get; set; }
        public Nullable<int> updatingUserID { get; set; }
        public System.DateTime dateAdded { get; set; }
        public string columnName { get; set; }
        public string newValue { get; set; }
        public string oldValue { get; set; }
        public string transactionID { get; set; }
    }
}
