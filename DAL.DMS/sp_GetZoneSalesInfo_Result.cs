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
    
    public partial class sp_GetZoneSalesInfo_Result
    {
        public string eName { get; set; }
        public decimal SalesDaily { get; set; }
        public decimal MonthlyTarget { get; set; }
        public decimal TotalOfMonth { get; set; }
        public decimal YearlyTarget { get; set; }
        public Nullable<decimal> TotalOfYear { get; set; }
    }
}
