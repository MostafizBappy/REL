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
    
    public partial class Product_Histoy
    {
        public long ProductHisAID { get; set; }
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string ProdName { get; set; }
        public string NameBan { get; set; }
        public string ModelSerial { get; set; }
        public string Model { get; set; }
        public Nullable<int> ModelMQSerial { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Country { get; set; }
        public string Measure { get; set; }
        public Nullable<int> QOH { get; set; }
        public Nullable<int> ReOrder { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> Date_time { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public string comcod { get; set; }
        public string color { get; set; }
        public string Specification { get; set; }
        public string ProdType { get; set; }
        public Nullable<decimal> VAt { get; set; }
        public Nullable<decimal> ComSho { get; set; }
        public Nullable<decimal> ComDel { get; set; }
        public string PCategory { get; set; }
        public string GroupName { get; set; }
        public string Discontinue { get; set; }
        public Nullable<int> GroupSL { get; set; }
        public Nullable<int> CustomsVAT { get; set; }
        public Nullable<int> ProdTag { get; set; }
        public string UserID { get; set; }
        public string PCName { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<byte> InActivePS { get; set; }
        public Nullable<decimal> DealerPrice { get; set; }
        public Nullable<int> HCHidden { get; set; }
        public Nullable<int> GetCommission { get; set; }
        public Nullable<double> VatPer { get; set; }
        public string DiscontinueType { get; set; }
        public string RegularDesc { get; set; }
        public Nullable<double> Size_Capacity { get; set; }
        public string Size_Capacity_Unit { get; set; }
        public Nullable<int> SCTag { get; set; }
        public string aCode { get; set; }
        public Nullable<int> aProductID { get; set; }
        public string CatCode { get; set; }
        public string CTPCode { get; set; }
        public Nullable<int> CTPID { get; set; }
        public string OrderType { get; set; }
        public string GroupPrefix { get; set; }
        public Nullable<int> GroupPrefixSL { get; set; }
        public Nullable<decimal> FOBPriceUSD { get; set; }
        public Nullable<int> HPSalesTag { get; set; }
        public Nullable<double> BLIPAmnt { get; set; }
        public Nullable<double> IncentiveAmnt { get; set; }
        public Nullable<bool> GetIncentive { get; set; }
        public Nullable<double> WPPrice { get; set; }
        public Nullable<double> BLIPofWP { get; set; }
        public Nullable<double> WPIncentive { get; set; }
        public Nullable<int> WPMinQty { get; set; }
        public string IncentiveType { get; set; }
    }
}
