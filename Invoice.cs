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
    
    public partial class Invoice
    {
        public int invoiceID { get; set; }
        public decimal amountPaid { get; set; }
        public Nullable<int> clientCorporationID { get; set; }
        public string comments { get; set; }
        public string costCenter { get; set; }
        public System.DateTime dateAdded { get; set; }
        public Nullable<System.DateTime> dateBegin { get; set; }
        public Nullable<System.DateTime> dateDue { get; set; }
        public Nullable<System.DateTime> dateEnd { get; set; }
        public Nullable<System.DateTime> dateExported { get; set; }
        public Nullable<System.DateTime> dateInvoice { get; set; }
        public System.DateTime dateLastModified { get; set; }
        public Nullable<int> fileExportID { get; set; }
        public Nullable<int> invoiceBatchID { get; set; }
        public short isDeleted { get; set; }
        public short isExported { get; set; }
        public Nullable<decimal> outstandingBalance { get; set; }
        public Nullable<int> recipientUserID { get; set; }
        public string status { get; set; }
        public string terms { get; set; }
        public int userID { get; set; }
    }
}
