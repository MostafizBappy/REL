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
    
    public partial class LCMaster
    {
        public string comcod { get; set; }
        public int MRSRMID { get; set; }
        public string LCNO { get; set; }
        public Nullable<System.DateTime> LCDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string ShipFrom { get; set; }
        public string LCRemarks { get; set; }
        public string UserID { get; set; }
        public string PCName { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}