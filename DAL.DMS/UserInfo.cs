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
    
    public partial class UserInfo
    {
        public int AutoID { get; set; }
        public string UserName { get; set; }
        public string PinCode { get; set; }
        public string UFName { get; set; }
        public Nullable<int> Admin { get; set; }
        public Nullable<int> Receive { get; set; }
        public Nullable<int> Issue { get; set; }
        public Nullable<int> WithdrawnOther { get; set; }
        public Nullable<int> Transfer { get; set; }
        public Nullable<int> Sales { get; set; }
        public Nullable<int> SalesWithdrawn { get; set; }
        public Nullable<int> Vat { get; set; }
    }
}