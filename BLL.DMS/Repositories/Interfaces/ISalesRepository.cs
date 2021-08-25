using BLL.DMS.ViewModel;
using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public interface ISalesRepository
    {
        List<VW_Sales_BILL> GetSalesBillByInvoice(string invoiceNo);
        List<SP_RPT_GET_SALES_INFO_Result> GetSalesInfo(DateTime date);
        List<SP_RPT_GET_SALES_INFO_CENTER_Result> GetSalesInfoCenter(DateTime date);
        List<SP_SALES_PERFORMANCE_Result> GetSalesPerformance(DateTime date);
        List<SP_SALES_PERFORMANCE_CENTER_Result> GetSalesPerformanceCenter(DateTime date);
        List<SP_SALES_DATE_AMOUNT_Result> GetDateWiseSalesInfo(DateTime date);
        List<sp_GetDealerSalesInfo_Result> GetDealerSales(DateTime date);
        List<sp_GetZoneSalesInfo_Result> GetZonalSales(DateTime date);
        List<sp_GetMonthlyTotalByZone_Result> GetTotalByZone(DateTime date);
        List<SP_RPT_GET_DEPOSIT_INFO_Result> GetDepositSales(DateTime date);
        List<SP_GET_MODEL_WISE_DATA_Result> GetDealerModelSales(DateTime fdate, DateTime tdate, int EID);

        List<SP_GET_TABLE_OF_CON_ASC_Result> SP_GET_TABLE_OF_CON_ASC(string order);
        List<SP_GET_TABLE_OF_CON_DESC_Result> SP_GET_TABLE_OF_CON_DESC(string order);

        List<SP_GET_MQ_CS_REPORT_Result> SP_GET_MQ_CS_REPORT();
        List<SP_SALES_QTY_JULY_Result> SP_SALES_QTY_JULY();
        List<SP_SALES_QTY_AUG_Result> SP_SALES_QTY_AUG();
        List<SP_SALES_QTY_SEP_Result> SP_SALES_QTY_SEP();
        List<SP_SALES_QTY_OCT_Result> SP_SALES_QTY_OCT();
        List<SP_SALES_QTY_NOV_Result> SP_SALES_QTY_NOV();
        List<SP_SALES_QTY_DEC_Result> SP_SALES_QTY_DEC();
        List<SP_SALES_QTY_JAN_Result> SP_SALES_QTY_JAN();
        List<SP_SALES_QTY_FEB_Result> SP_SALES_QTY_FEB();
        List<SP_SALES_QTY_MAR_Result> SP_SALES_QTY_MAR();
        List<SP_SALES_QTY_APR_Result> SP_SALES_QTY_APR();
        List<SP_SALES_QTY_MAY_Result> SP_SALES_QTY_MAY();
        List<SP_SALES_QTY_JUN_Result> SP_SALES_QTY_JUN();

        List<SP_DEALER_ACCOUNT_INFO_Result> SP_DEALER_ACCOUNT_INFO(DateTime FROMDATE, DateTime TODATE, string USERID, string ZONE, string Dealer);
        List<sp_DailyProductSalesQuantity_Result> GetDailySalesQuantity(DateTime date);


        #region Sales Entry
        string GetInvoiceNo(string sessionUser);
        ProductViewModel GetProductInfoById(int productId);
        CustomerViewModel GetCustomerInfo(string mobileNo);
        ProductViewModel GetProductInfoByCode(string prodCode);
        EntityViewModel GetSellerInfo(string entityCode);
        List<tbTC> GetTermsAndConditionsList();
        #endregion

        #region MQ Report
        List<SP_GET_MQ_REPORT_DATA_Result> SP_GET_MQ_REPORT_DATA();
        #endregion MQ Report
    }
}
