//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DMS
{
    using System;
    
    public partial class SP_RPT_GET_DEPOSIT_INFO_Result
    {
        public string eName { get; set; }
        public decimal SalesDaily { get; set; }
        public Nullable<decimal> CashD { get; set; }
        public Nullable<decimal> CardD { get; set; }
        public Nullable<int> ChequeD { get; set; }
        public decimal MonthlyTarget { get; set; }
        public decimal TotalOfMonth { get; set; }
        public Nullable<decimal> CashM { get; set; }
        public Nullable<decimal> CardM { get; set; }
        public Nullable<int> ChequeM { get; set; }
        public decimal YearlyTarget { get; set; }
        public Nullable<decimal> TotalOfYear { get; set; }
        public Nullable<decimal> CashY { get; set; }
        public Nullable<decimal> CardY { get; set; }
        public int ChequeY { get; set; }
    }
}
