//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMSWeb.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_LoanPayments
    {
        public int Id { get; set; }
        public Nullable<int> LoanID { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public string PaidStatus { get; set; }
    
        public virtual tbl_Loan tbl_Loan { get; set; }
    }
}