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
    
    public partial class TimecardExpense
    {
        public int timecardExpenseID { get; set; }
        public Nullable<double> amount { get; set; }
        public string comments { get; set; }
        public System.DateTime dateAdded { get; set; }
        public System.DateTime dateExpensed { get; set; }
        public Nullable<int> fileExportID { get; set; }
        public Nullable<int> invoiceID { get; set; }
        public Nullable<int> invoiceItemID { get; set; }
        public int lastModifyingPersonID { get; set; }
        public Nullable<int> payClassID { get; set; }
        public int placementID { get; set; }
        public string projectID { get; set; }
        public Nullable<int> timecardID { get; set; }
    }
}
