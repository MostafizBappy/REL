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
    using System.Collections.Generic;
    
    public partial class tbCustomerVoucher
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContact { get; set; }
        public string InvoiceNo { get; set; }
        public int BillAmount { get; set; }
        public int EarnedVoucherPoint { get; set; }
        public int RedeemVoucherPoint { get; set; }
        public string RefInvoiceNo { get; set; }
    }
}
