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
    
    public partial class SP_DEALER_ACCOUNT_INFO_Result
    {
        public string ZoneName { get; set; }
        public Nullable<int> DelearID { get; set; }
        public string DelearName { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<decimal> DeliveryAmount { get; set; }
        public Nullable<decimal> Withdrawn { get; set; }
        public Nullable<decimal> ActualDelivery { get; set; }
        public Nullable<decimal> TotalBalance { get; set; }
        public Nullable<decimal> BankDeposit { get; set; }
        public Nullable<decimal> DishonourAmnt { get; set; }
        public Nullable<decimal> CB { get; set; }
    }
}
