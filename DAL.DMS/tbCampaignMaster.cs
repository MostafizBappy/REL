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
    
    public partial class tbCampaignMaster
    {
        public int CamAID { get; set; }
        public string CampaignNo { get; set; }
        public string CampaignName { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string UserID { get; set; }
        public string PCName { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<int> cTag { get; set; }
        public Nullable<int> cStop { get; set; }
        public Nullable<System.DateTime> cStopDate { get; set; }
    }
}
