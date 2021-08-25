using AutoMapper;
using BLL.DMS.Helpers;
using BLL.DMS.ViewModel;
using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        private readonly dbCIDEntities _context;
        private readonly IMapper _mapper;
        public SalesRepository(dbCIDEntities context)
        {
            _context = context;
            _context.Database.CommandTimeout = 0;
            _mapper = AutoMapperProfiles.Mapper;
        }
        public List<VW_Sales_BILL> GetSalesBillByInvoice(string invoiceNo)
        {
            return _context.VW_Sales_BILL.Where(b => b.MRSRCode == invoiceNo).ToList();
        }

        public List<SP_RPT_GET_SALES_INFO_Result> GetSalesInfo(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@S_DATE", date);
            return _context.Database.SqlQuery<SP_RPT_GET_SALES_INFO_Result>("exec SP_RPT_GET_SALES_INFO @S_DATE", dateParam).ToList();
        }

        public List<SP_SALES_PERFORMANCE_Result> GetSalesPerformance(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<SP_SALES_PERFORMANCE_Result>("exec SP_SALES_PERFORMANCE @DATE", dateParam).ToList();
        }

        public List<SP_RPT_GET_SALES_INFO_CENTER_Result> GetSalesInfoCenter(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@S_DATE", date);
            return _context.Database.SqlQuery<SP_RPT_GET_SALES_INFO_CENTER_Result>("exec SP_RPT_GET_SALES_INFO_CENTER @S_DATE", dateParam).ToList();
        }

        public List<SP_SALES_PERFORMANCE_CENTER_Result> GetSalesPerformanceCenter(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<SP_SALES_PERFORMANCE_CENTER_Result>("exec SP_SALES_PERFORMANCE_CENTER @DATE", dateParam).ToList();
        }

        public List<SP_SALES_DATE_AMOUNT_Result> GetDateWiseSalesInfo(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<SP_SALES_DATE_AMOUNT_Result>("exec SP_SALES_DATE_AMOUNT @DATE", dateParam).ToList();
        }

        public List<sp_GetDealerSalesInfo_Result> GetDealerSales(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@S_DATE", date);
            return _context.Database.SqlQuery<sp_GetDealerSalesInfo_Result>("exec sp_GetDealerSalesInfo @S_DATE", dateParam).ToList();
        }

        public List<sp_GetZoneSalesInfo_Result> GetZonalSales(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<sp_GetZoneSalesInfo_Result>("exec sp_GetZoneSalesInfo @DATE", dateParam).ToList();
        }

        public List<sp_GetMonthlyTotalByZone_Result> GetTotalByZone(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<sp_GetMonthlyTotalByZone_Result>("exec sp_GetMonthlyTotalByZone @DATE", dateParam).ToList();
        }

        #region Sales 3 and Salse 4 Report 
        public List<SP_RPT_GET_DEPOSIT_INFO_Result> GetDepositSales(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<SP_RPT_GET_DEPOSIT_INFO_Result>("exec SP_RPT_GET_DEPOSIT_INFO @DATE", dateParam).ToList();
        }

        public List<SP_GET_MODEL_WISE_DATA_Result> GetDealerModelSales(DateTime fdate, DateTime tdate, int EID)
        {
            SqlParameter Fdate = new SqlParameter("@FROM_DATE", fdate);
            SqlParameter Tdate = new SqlParameter("@TO_DATE", tdate);
            SqlParameter Eid = new SqlParameter("@EID", EID);
            return _context.Database.SqlQuery<SP_GET_MODEL_WISE_DATA_Result>("exec SP_GET_MODEL_WISE_DATA @FROM_DATE, @TO_DATE, @EID", Fdate, Tdate, Eid).ToList();
        }

        public List<SP_GET_TABLE_OF_CON_ASC_Result> SP_GET_TABLE_OF_CON_ASC(string order)
        {
            SqlParameter ORDER = new SqlParameter("@ORDER", order);
            return _context.Database.SqlQuery<SP_GET_TABLE_OF_CON_ASC_Result>("exec SP_GET_TABLE_OF_CON_ASC @ORDER", ORDER).ToList();
        }

        public List<SP_GET_TABLE_OF_CON_DESC_Result> SP_GET_TABLE_OF_CON_DESC(string order)
        {
            SqlParameter ORDER = new SqlParameter("@ORDER", order);
            return _context.Database.SqlQuery<SP_GET_TABLE_OF_CON_DESC_Result>("exec SP_GET_TABLE_OF_CON_DESC @ORDER", ORDER).ToList();
        }

        //public List<EntityModel> GetALLDealerEntity()
        //{ 
        //    return _context.Database.SqlQuery<EntityModel>("Select EID, Convert(VARCHAR,EID)+'-'+eName NAME from Entityfrom Entity Where EntityType='Dealer' and ActiveDeactive=1").ToList();
        //}
        public List<SP_GET_MQ_CS_REPORT_Result> SP_GET_MQ_CS_REPORT()
        {
            return _context.Database.SqlQuery<SP_GET_MQ_CS_REPORT_Result>("exec SP_GET_MQ_CS_REPORT").ToList();
        }

        public List<SP_SALES_QTY_JULY_Result> SP_SALES_QTY_JULY()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_JULY_Result>("exec SP_SALES_QTY_JULY").ToList();
        }
        public List<SP_SALES_QTY_AUG_Result> SP_SALES_QTY_AUG()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_AUG_Result>("exec SP_SALES_QTY_AUG").ToList();
        }
        public List<SP_SALES_QTY_SEP_Result> SP_SALES_QTY_SEP()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_SEP_Result>("exec SP_SALES_QTY_SEP").ToList();
        }
        public List<SP_SALES_QTY_OCT_Result> SP_SALES_QTY_OCT()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_OCT_Result>("exec SP_SALES_QTY_OCT").ToList();
        }
        public List<SP_SALES_QTY_NOV_Result> SP_SALES_QTY_NOV()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_NOV_Result>("exec SP_SALES_QTY_NOV").ToList();
        }
        public List<SP_SALES_QTY_DEC_Result> SP_SALES_QTY_DEC()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_DEC_Result>("exec SP_SALES_QTY_DEC").ToList();
        }
        public List<SP_SALES_QTY_JAN_Result> SP_SALES_QTY_JAN()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_JAN_Result>("exec SP_SALES_QTY_JAN").ToList();
        }
        public List<SP_SALES_QTY_FEB_Result> SP_SALES_QTY_FEB()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_FEB_Result>("exec SP_SALES_QTY_FEB").ToList();
        }
        public List<SP_SALES_QTY_MAR_Result> SP_SALES_QTY_MAR()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_MAR_Result>("exec SP_SALES_QTY_MAR").ToList();
        }
        public List<SP_SALES_QTY_APR_Result> SP_SALES_QTY_APR()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_APR_Result>("exec SP_SALES_QTY_APR").ToList();
        }
        public List<SP_SALES_QTY_MAY_Result> SP_SALES_QTY_MAY()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_MAY_Result>("exec SP_SALES_QTY_MAY").ToList();
        }
        public List<SP_SALES_QTY_JUN_Result> SP_SALES_QTY_JUN()
        {
            return _context.Database.SqlQuery<SP_SALES_QTY_JUN_Result>("exec SP_SALES_QTY_JUN").ToList();
        }

        public List<SP_DEALER_ACCOUNT_INFO_Result> SP_DEALER_ACCOUNT_INFO(DateTime FROMDATE, DateTime TODATE, string USERID, string ZONE, string Dealer)
        {
            SqlParameter FDATE = new SqlParameter("@FROMDATE", FROMDATE);
            SqlParameter TDATE = new SqlParameter("@TODATE", TODATE);
            SqlParameter UID = new SqlParameter("@USERID", USERID);
            SqlParameter ZN = new SqlParameter("@ZONE", ZONE);
            SqlParameter DR = new SqlParameter("@DELEAR", Dealer);
            return _context.Database.SqlQuery<SP_DEALER_ACCOUNT_INFO_Result>("exec SP_DEALER_ACCOUNT_INFO @FROMDATE, @TODATE, @USERID , @ZONE, @DELEAR", FDATE, TDATE, UID, ZN, DR).ToList();
        }

        #endregion

        #region Sales Entry
        public string GetInvoiceNo(string sessionBrCode)
        {
            string invoiceNo = String.Empty;
            string param = sessionBrCode + "/" + DateTime.Now.ToString("yyyy") + "/";
            var lastInvoice = _context.MRSRMasters.Where(x => x.MRSRCode.Substring(0, 12) == param & x.TrType == 3).Max(x => x.MRSRCode);
            if(!String.IsNullOrEmpty(lastInvoice))
            {
                string lastNo = lastInvoice.Substring(lastInvoice.Length - 5, 5);
                int currentNo = Convert.ToInt32(lastNo) + 1;
                invoiceNo = "" + sessionBrCode + "/" + DateTime.Now.ToString("yyyy") + "/" + currentNo.ToString("00000");
            }
            return invoiceNo;
        }

        public ProductViewModel GetProductInfoById(int productId)
        {
            Product prodInfo = _context.Products.FirstOrDefault(x => x.ProductID == productId);
            ProductViewModel viewModel = _mapper.Map<ProductViewModel>(prodInfo);
            VW_CampaignInfo campaignInfo = _context.VW_CampaignInfo
                .Where(x => x.ProductID == productId && x.EffectiveDate <= DateTime.Today && x.cStop == 0).OrderByDescending(x => x.EffectiveDate).FirstOrDefault();
            if(prodInfo != null)
            {
                if(campaignInfo != null)
                {
                    viewModel.CampaignPrice = viewModel.UnitPrice - campaignInfo.DisAmnt;
                }
                else
                {
                    viewModel.CampaignPrice = viewModel.UnitPrice;
                }
            }
            return viewModel;
        }

        public CustomerViewModel GetCustomerInfo(string mobileNo)
        {
            CustomerViewModel cusViewModel = new CustomerViewModel();
            if (!String.IsNullOrEmpty(mobileNo))
            {
                Customer customer = _context.Customers.FirstOrDefault(x => x.Mobile == mobileNo);
                cusViewModel = _mapper.Map<CustomerViewModel>(customer);
            }
            return cusViewModel;
        }
        public ProductViewModel GetProductInfoByCode(string prodCode)
        {
            ProductViewModel viewModel = new ProductViewModel();
            Product prodInfo = _context.Products.FirstOrDefault(x => x.Code == prodCode);
            if (prodInfo != null)
            {
                viewModel = _mapper.Map<ProductViewModel>(prodInfo);
                VW_CampaignInfo campaignInfo = _context.VW_CampaignInfo
                    .Where(x => x.ProductID == prodInfo.ProductID && x.EffectiveDate <= DateTime.Today && x.cStop == 0).OrderByDescending(x => x.EffectiveDate).FirstOrDefault();

                if (campaignInfo != null)
                {
                    viewModel.CampaignPrice = viewModel.UnitPrice - campaignInfo.DisAmnt;
                }
                else
                {
                    viewModel.CampaignPrice = viewModel.UnitPrice;
                }
            }

            return viewModel;
        }

        public EntityViewModel GetSellerInfo(string entityCode)
        {
            EntityViewModel viewModel = new EntityViewModel();
            var entity = _context.Entities.FirstOrDefault(x => x.EntityCode == entityCode);
            if(entity != null)
            {
                viewModel = _mapper.Map<EntityViewModel>(entity);
            }
            return viewModel;
        }

        public List<tbTC> GetTermsAndConditionsList()
        {
            return _context.tbTCs.OrderBy(x => x.OrderBy).ToList();
        }

        #endregion


        public List<SP_GET_MQ_REPORT_DATA_Result> SP_GET_MQ_REPORT_DATA()
        {
            return _context.Database.SqlQuery<SP_GET_MQ_REPORT_DATA_Result>("exec SP_GET_MQ_REPORT_DATA").ToList();
        }

        public List<sp_DailyProductSalesQuantity_Result> GetDailySalesQuantity(DateTime date)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            return _context.Database.SqlQuery<sp_DailyProductSalesQuantity_Result>("exec sp_GetMonthlyTotalByZone @DATE", dateParam).ToList();
        }
    }
}
