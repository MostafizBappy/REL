﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbCIDEntities : DbContext
    {
        public dbCIDEntities()
            : base("name=dbCIDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<tbCampaignMaster> tbCampaignMasters { get; set; }
        public virtual DbSet<tbCustomerVoucher> tbCustomerVouchers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EntityType> EntityTypes { get; set; }
        public virtual DbSet<LCDetail> LCDetails { get; set; }
        public virtual DbSet<LCMaster> LCMasters { get; set; }
        public virtual DbSet<MRSRDetail> MRSRDetails { get; set; }
        public virtual DbSet<MRSRMaster> MRSRMasters { get; set; }
        public virtual DbSet<Product_Histoy> Product_Histoy { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ReceiveProductSerial> ReceiveProductSerials { get; set; }
        public virtual DbSet<RequirmentDetail> RequirmentDetails { get; set; }
        public virtual DbSet<SoftUser> SoftUsers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierProduct> SupplierProducts { get; set; }
        public virtual DbSet<tbCarrierInfo> tbCarrierInfoes { get; set; }
        public virtual DbSet<tbCarryingCharge> tbCarryingCharges { get; set; }
        public virtual DbSet<tbMenu> tbMenus { get; set; }
        public virtual DbSet<tbSM> tbSMS { get; set; }
        public virtual DbSet<tbSMSRead> tbSMSReads { get; set; }
        public virtual DbSet<tbSMSReceipentList> tbSMSReceipentLists { get; set; }
        public virtual DbSet<tbSMSReceipentReport> tbSMSReceipentReports { get; set; }
        public virtual DbSet<tbStoreInfo> tbStoreInfoes { get; set; }
        public virtual DbSet<tbTagPromocode> tbTagPromocodes { get; set; }
        public virtual DbSet<tbTarget> tbTargets { get; set; }
        public virtual DbSet<tbTargetYearly> tbTargetYearlies { get; set; }
        public virtual DbSet<tbTC> tbTCs { get; set; }
        public virtual DbSet<tbTC_Customer> tbTC_Customer { get; set; }
        public virtual DbSet<tbTermsCondition> tbTermsConditions { get; set; }
        public virtual DbSet<tbVATMaster> tbVATMasters { get; set; }
        public virtual DbSet<tbVehicleInfo> tbVehicleInfoes { get; set; }
        public virtual DbSet<tbVendorInfo> tbVendorInfoes { get; set; }
        public virtual DbSet<TrType> TrTypes { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<UserLoginTrack> UserLoginTracks { get; set; }
        public virtual DbSet<UserScreenList> UserScreenLists { get; set; }
        public virtual DbSet<VW_Sales_BILL> VW_Sales_BILL { get; set; }
        public virtual DbSet<VW_Search_Sales> VW_Search_Sales { get; set; }
        public virtual DbSet<tbDistThana> tbDistThanas { get; set; }
        public virtual DbSet<tblMainMenu> tblMainMenus { get; set; }
        public virtual DbSet<tblSubMenu> tblSubMenus { get; set; }
        public virtual DbSet<VW_CampaignInfo> VW_CampaignInfo { get; set; }
    
        public virtual ObjectResult<sp_GetZoneSalesInfo_Result> sp_GetZoneSalesInfo(Nullable<System.DateTime> s_DATE)
        {
            var s_DATEParameter = s_DATE.HasValue ?
                new ObjectParameter("S_DATE", s_DATE) :
                new ObjectParameter("S_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetZoneSalesInfo_Result>("sp_GetZoneSalesInfo", s_DATEParameter);
        }
    
        public virtual ObjectResult<SP_HC_Pending_ChallanWise_Result> SP_HC_Pending_ChallanWise(string sCarrierName)
        {
            var sCarrierNameParameter = sCarrierName != null ?
                new ObjectParameter("sCarrierName", sCarrierName) :
                new ObjectParameter("sCarrierName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_HC_Pending_ChallanWise_Result>("SP_HC_Pending_ChallanWise", sCarrierNameParameter);
        }
    
        public virtual ObjectResult<SP_HC_Product_Result> SP_HC_Product()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_HC_Product_Result>("SP_HC_Product");
        }
    
        public virtual ObjectResult<SP_HC_Product_Stock_Result> SP_HC_Product_Stock(Nullable<int> sTag)
        {
            var sTagParameter = sTag.HasValue ?
                new ObjectParameter("sTag", sTag) :
                new ObjectParameter("sTag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_HC_Product_Stock_Result>("SP_HC_Product_Stock", sTagParameter);
        }
    
        public virtual ObjectResult<SP_LC_Product_Result> SP_LC_Product(Nullable<int> sTag)
        {
            var sTagParameter = sTag.HasValue ?
                new ObjectParameter("sTag", sTag) :
                new ObjectParameter("sTag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LC_Product_Result>("SP_LC_Product", sTagParameter);
        }
    
        public virtual ObjectResult<sp_LC_Product_Stock_Result> sp_LC_Product_Stock()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_LC_Product_Stock_Result>("sp_LC_Product_Stock");
        }
    
        public virtual ObjectResult<SP_LC_Wise_DUE_Result> SP_LC_Wise_DUE(string sLCNO)
        {
            var sLCNOParameter = sLCNO != null ?
                new ObjectParameter("sLCNO", sLCNO) :
                new ObjectParameter("sLCNO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LC_Wise_DUE_Result>("SP_LC_Wise_DUE", sLCNOParameter);
        }
    
        public virtual ObjectResult<SP_RPT_GET_DEPOSIT_INFO_Result> SP_RPT_GET_DEPOSIT_INFO(Nullable<System.DateTime> s_DATE)
        {
            var s_DATEParameter = s_DATE.HasValue ?
                new ObjectParameter("S_DATE", s_DATE) :
                new ObjectParameter("S_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_GET_DEPOSIT_INFO_Result>("SP_RPT_GET_DEPOSIT_INFO", s_DATEParameter);
        }
    
        public virtual ObjectResult<SP_RPT_GET_SALES_INFO_Result> SP_RPT_GET_SALES_INFO(Nullable<System.DateTime> s_DATE)
        {
            var s_DATEParameter = s_DATE.HasValue ?
                new ObjectParameter("S_DATE", s_DATE) :
                new ObjectParameter("S_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_GET_SALES_INFO_Result>("SP_RPT_GET_SALES_INFO", s_DATEParameter);
        }
    
        public virtual ObjectResult<SP_SALES_DATE_AMOUNT_Result> SP_SALES_DATE_AMOUNT(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_DATE_AMOUNT_Result>("SP_SALES_DATE_AMOUNT", dATEParameter);
        }
    
        public virtual ObjectResult<SP_SALES_PERFORMANCE_Result> SP_SALES_PERFORMANCE(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_PERFORMANCE_Result>("SP_SALES_PERFORMANCE", dATEParameter);
        }
    
        public virtual ObjectResult<SP_Total_Sales_Result> SP_Total_Sales(Nullable<int> sTag, Nullable<System.DateTime> tDate)
        {
            var sTagParameter = sTag.HasValue ?
                new ObjectParameter("sTag", sTag) :
                new ObjectParameter("sTag", typeof(int));
    
            var tDateParameter = tDate.HasValue ?
                new ObjectParameter("tDate", tDate) :
                new ObjectParameter("tDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Total_Sales_Result>("SP_Total_Sales", sTagParameter, tDateParameter);
        }
    
        public virtual ObjectResult<SP_Total_Sales_Irregular_Result> SP_Total_Sales_Irregular(Nullable<System.DateTime> tDate)
        {
            var tDateParameter = tDate.HasValue ?
                new ObjectParameter("tDate", tDate) :
                new ObjectParameter("tDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Total_Sales_Irregular_Result>("SP_Total_Sales_Irregular", tDateParameter);
        }
    
        public virtual ObjectResult<SP_Total_Sales_Regular_Result> SP_Total_Sales_Regular(Nullable<System.DateTime> tDate)
        {
            var tDateParameter = tDate.HasValue ?
                new ObjectParameter("tDate", tDate) :
                new ObjectParameter("tDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Total_Sales_Regular_Result>("SP_Total_Sales_Regular", tDateParameter);
        }
    
        public virtual int spRPTBalance(string sUser, string pCname, string sBranch, Nullable<System.DateTime> sDate)
        {
            var sUserParameter = sUser != null ?
                new ObjectParameter("sUser", sUser) :
                new ObjectParameter("sUser", typeof(string));
    
            var pCnameParameter = pCname != null ?
                new ObjectParameter("PCname", pCname) :
                new ObjectParameter("PCname", typeof(string));
    
            var sBranchParameter = sBranch != null ?
                new ObjectParameter("sBranch", sBranch) :
                new ObjectParameter("sBranch", typeof(string));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("sDate", sDate) :
                new ObjectParameter("sDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRPTBalance", sUserParameter, pCnameParameter, sBranchParameter, sDateParameter);
        }
    
        public virtual int spRPTBalance_Final(string sUser, string pCname, string sBranch)
        {
            var sUserParameter = sUser != null ?
                new ObjectParameter("sUser", sUser) :
                new ObjectParameter("sUser", typeof(string));
    
            var pCnameParameter = pCname != null ?
                new ObjectParameter("PCname", pCname) :
                new ObjectParameter("PCname", typeof(string));
    
            var sBranchParameter = sBranch != null ?
                new ObjectParameter("sBranch", sBranch) :
                new ObjectParameter("sBranch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRPTBalance_Final", sUserParameter, pCnameParameter, sBranchParameter);
        }
    
        public virtual int spRPTBalance_GroupWise(string sUser, string pCname, string sBranch, Nullable<System.DateTime> sDate, string pGroup)
        {
            var sUserParameter = sUser != null ?
                new ObjectParameter("sUser", sUser) :
                new ObjectParameter("sUser", typeof(string));
    
            var pCnameParameter = pCname != null ?
                new ObjectParameter("PCname", pCname) :
                new ObjectParameter("PCname", typeof(string));
    
            var sBranchParameter = sBranch != null ?
                new ObjectParameter("sBranch", sBranch) :
                new ObjectParameter("sBranch", typeof(string));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("sDate", sDate) :
                new ObjectParameter("sDate", typeof(System.DateTime));
    
            var pGroupParameter = pGroup != null ?
                new ObjectParameter("pGroup", pGroup) :
                new ObjectParameter("pGroup", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRPTBalance_GroupWise", sUserParameter, pCnameParameter, sBranchParameter, sDateParameter, pGroupParameter);
        }
    
        public virtual int spRPTBalancePS(string sUser, string pCname, string sBranch, Nullable<System.DateTime> sDate)
        {
            var sUserParameter = sUser != null ?
                new ObjectParameter("sUser", sUser) :
                new ObjectParameter("sUser", typeof(string));
    
            var pCnameParameter = pCname != null ?
                new ObjectParameter("PCname", pCname) :
                new ObjectParameter("PCname", typeof(string));
    
            var sBranchParameter = sBranch != null ?
                new ObjectParameter("sBranch", sBranch) :
                new ObjectParameter("sBranch", typeof(string));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("sDate", sDate) :
                new ObjectParameter("sDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRPTBalancePS", sUserParameter, pCnameParameter, sBranchParameter, sDateParameter);
        }
    
        public virtual ObjectResult<spSearch_SalesInfo_Result> spSearch_SalesInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSearch_SalesInfo_Result>("spSearch_SalesInfo");
        }
    
        public virtual ObjectResult<SP_GET_TABLE_OF_CON_ASC_Result> SP_GET_TABLE_OF_CON_ASC(string oRDER)
        {
            var oRDERParameter = oRDER != null ?
                new ObjectParameter("ORDER", oRDER) :
                new ObjectParameter("ORDER", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_TABLE_OF_CON_ASC_Result>("SP_GET_TABLE_OF_CON_ASC", oRDERParameter);
        }
    
        public virtual ObjectResult<SP_GET_TABLE_OF_CON_DESC_Result> SP_GET_TABLE_OF_CON_DESC(string oRDER)
        {
            var oRDERParameter = oRDER != null ?
                new ObjectParameter("ORDER", oRDER) :
                new ObjectParameter("ORDER", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_TABLE_OF_CON_DESC_Result>("SP_GET_TABLE_OF_CON_DESC", oRDERParameter);
        }
    
        public virtual ObjectResult<SP_RPT_GET_SALES_INFO_CENTER_Result> SP_RPT_GET_SALES_INFO_CENTER(Nullable<System.DateTime> s_DATE)
        {
            var s_DATEParameter = s_DATE.HasValue ?
                new ObjectParameter("S_DATE", s_DATE) :
                new ObjectParameter("S_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_GET_SALES_INFO_CENTER_Result>("SP_RPT_GET_SALES_INFO_CENTER", s_DATEParameter);
        }
    
        public virtual ObjectResult<SP_SALES_PERFORMANCE_CENTER_Result> SP_SALES_PERFORMANCE_CENTER(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_PERFORMANCE_CENTER_Result>("SP_SALES_PERFORMANCE_CENTER", dATEParameter);
        }
    
        public virtual ObjectResult<SP_GET_MODEL_WISE_DATA_Result> SP_GET_MODEL_WISE_DATA(Nullable<System.DateTime> fROM_DATE, Nullable<System.DateTime> tO_DATE, Nullable<int> eID)
        {
            var fROM_DATEParameter = fROM_DATE.HasValue ?
                new ObjectParameter("FROM_DATE", fROM_DATE) :
                new ObjectParameter("FROM_DATE", typeof(System.DateTime));
    
            var tO_DATEParameter = tO_DATE.HasValue ?
                new ObjectParameter("TO_DATE", tO_DATE) :
                new ObjectParameter("TO_DATE", typeof(System.DateTime));
    
            var eIDParameter = eID.HasValue ?
                new ObjectParameter("EID", eID) :
                new ObjectParameter("EID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_MODEL_WISE_DATA_Result>("SP_GET_MODEL_WISE_DATA", fROM_DATEParameter, tO_DATEParameter, eIDParameter);
        }
    
        public virtual ObjectResult<sp_EntityDateWiseStock_Result> sp_EntityDateWiseStock(Nullable<System.DateTime> dATE, Nullable<int> entityID, string groupName)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var entityIDParameter = entityID.HasValue ?
                new ObjectParameter("EntityID", entityID) :
                new ObjectParameter("EntityID", typeof(int));
    
            var groupNameParameter = groupName != null ?
                new ObjectParameter("GroupName", groupName) :
                new ObjectParameter("GroupName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_EntityDateWiseStock_Result>("sp_EntityDateWiseStock", dATEParameter, entityIDParameter, groupNameParameter);
        }
    
        public virtual ObjectResult<sp_GroupWiseOpeningStock_Result> sp_GroupWiseOpeningStock(Nullable<System.DateTime> dATE, string groupName)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var groupNameParameter = groupName != null ?
                new ObjectParameter("GroupName", groupName) :
                new ObjectParameter("GroupName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GroupWiseOpeningStock_Result>("sp_GroupWiseOpeningStock", dATEParameter, groupNameParameter);
        }
    
        public virtual ObjectResult<sp_GetDealerSalesInfo_Result> sp_GetDealerSalesInfo(Nullable<System.DateTime> s_DATE)
        {
            var s_DATEParameter = s_DATE.HasValue ?
                new ObjectParameter("S_DATE", s_DATE) :
                new ObjectParameter("S_DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDealerSalesInfo_Result>("sp_GetDealerSalesInfo", s_DATEParameter);
        }
    
        public virtual ObjectResult<sp_GetMonthlyTotalByZone_Result> sp_GetMonthlyTotalByZone(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetMonthlyTotalByZone_Result>("sp_GetMonthlyTotalByZone", dATEParameter);
        }
    
        public virtual ObjectResult<SP_GET_MQ_CS_REPORT_Result> SP_GET_MQ_CS_REPORT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_MQ_CS_REPORT_Result>("SP_GET_MQ_CS_REPORT");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_APR_Result> SP_SALES_QTY_APR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_APR_Result>("SP_SALES_QTY_APR");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_AUG_Result> SP_SALES_QTY_AUG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_AUG_Result>("SP_SALES_QTY_AUG");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_DEC_Result> SP_SALES_QTY_DEC()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_DEC_Result>("SP_SALES_QTY_DEC");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_FEB_Result> SP_SALES_QTY_FEB()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_FEB_Result>("SP_SALES_QTY_FEB");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_JAN_Result> SP_SALES_QTY_JAN()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_JAN_Result>("SP_SALES_QTY_JAN");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_JULY_Result> SP_SALES_QTY_JULY()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_JULY_Result>("SP_SALES_QTY_JULY");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_JUN_Result> SP_SALES_QTY_JUN()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_JUN_Result>("SP_SALES_QTY_JUN");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_MAR_Result> SP_SALES_QTY_MAR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_MAR_Result>("SP_SALES_QTY_MAR");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_MAY_Result> SP_SALES_QTY_MAY()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_MAY_Result>("SP_SALES_QTY_MAY");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_NOV_Result> SP_SALES_QTY_NOV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_NOV_Result>("SP_SALES_QTY_NOV");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_OCT_Result> SP_SALES_QTY_OCT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_OCT_Result>("SP_SALES_QTY_OCT");
        }
    
        public virtual ObjectResult<SP_SALES_QTY_SEP_Result> SP_SALES_QTY_SEP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SALES_QTY_SEP_Result>("SP_SALES_QTY_SEP");
        }
    
        public virtual ObjectResult<SP_DEALER_ACCOUNT_INFO_Result> SP_DEALER_ACCOUNT_INFO(Nullable<System.DateTime> fROMDATE, Nullable<System.DateTime> tODATE, string uSERID, string zONE, string dELEAR)
        {
            var fROMDATEParameter = fROMDATE.HasValue ?
                new ObjectParameter("FROMDATE", fROMDATE) :
                new ObjectParameter("FROMDATE", typeof(System.DateTime));
    
            var tODATEParameter = tODATE.HasValue ?
                new ObjectParameter("TODATE", tODATE) :
                new ObjectParameter("TODATE", typeof(System.DateTime));
    
            var uSERIDParameter = uSERID != null ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(string));
    
            var zONEParameter = zONE != null ?
                new ObjectParameter("ZONE", zONE) :
                new ObjectParameter("ZONE", typeof(string));
    
            var dELEARParameter = dELEAR != null ?
                new ObjectParameter("DELEAR", dELEAR) :
                new ObjectParameter("DELEAR", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DEALER_ACCOUNT_INFO_Result>("SP_DEALER_ACCOUNT_INFO", fROMDATEParameter, tODATEParameter, uSERIDParameter, zONEParameter, dELEARParameter);
        }
    
        public virtual ObjectResult<SP_GET_MQ_REPORT_DATA_Result> SP_GET_MQ_REPORT_DATA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_MQ_REPORT_DATA_Result>("SP_GET_MQ_REPORT_DATA");
        }
    
        public virtual ObjectResult<sp_GroupWiseDistributionPlan_Result> sp_GroupWiseDistributionPlan(Nullable<System.DateTime> dATE, string group, Nullable<int> withZone)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            var groupParameter = group != null ?
                new ObjectParameter("Group", group) :
                new ObjectParameter("Group", typeof(string));
    
            var withZoneParameter = withZone.HasValue ?
                new ObjectParameter("withZone", withZone) :
                new ObjectParameter("withZone", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GroupWiseDistributionPlan_Result>("sp_GroupWiseDistributionPlan", dATEParameter, groupParameter, withZoneParameter);
        }
    
        public virtual ObjectResult<sp_DailyProductSalesQuantity_Result> sp_DailyProductSalesQuantity(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DailyProductSalesQuantity_Result>("sp_DailyProductSalesQuantity", dATEParameter);
        }
    }
}
