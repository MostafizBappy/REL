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
    
    public partial class tbVATMaster
    {
        public int MRSRID { get; set; }
        public string CHNO { get; set; }
        public Nullable<System.DateTime> CHDate { get; set; }
        public Nullable<System.DateTime> CHTime { get; set; }
        public string IssueCHNO { get; set; }
        public string TransportTypeNO { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> DeliveryTime { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public Nullable<decimal> TotalAmnt { get; set; }
        public Nullable<decimal> TotalVat { get; set; }
        public Nullable<decimal> NetTotal { get; set; }
        public string TakaInWord { get; set; }
    }
}
