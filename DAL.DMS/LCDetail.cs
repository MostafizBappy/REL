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
    
    public partial class LCDetail
    {
        public string comcod { get; set; }
        public int MRSRDID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> MRSRMID { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<decimal> TotalAmnt { get; set; }
        public string JobNmbr { get; set; }
        public Nullable<int> QtyUsed { get; set; }
        public string RPCode { get; set; }
        public string OdrNmbr { get; set; }
        public string Origin { get; set; }
        public Nullable<double> UnitPriceUSD { get; set; }
        public string UnitName { get; set; }
        public string SLNO { get; set; }
        public string Color { get; set; }
        public string ProdCond { get; set; }
        public string BarCode { get; set; }
        public string ProdRemarks { get; set; }
    }
}
