using BLL.DMS.Repositories;
using BLL.DMS.ViewModel;
using DAL.DMS;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Web.DMS.Controllers
{
    [Authorize]
    public class SalesReportController : Controller
    {
        // GET: SalesReport
        private readonly ISalesRepository _salesRepo;
        public SalesReportController(ISalesRepository salesRepo)
        {
            _salesRepo = salesRepo;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string invoiceNo)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<VW_Sales_BILL> dataList = _salesRepo.GetSalesBillByInvoice(invoiceNo);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\SalesBillReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesBillDataSet", dataList));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        public ActionResult SalesInfo1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalesInfo1(DateTime date)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);

            try
            {
                List<SP_RPT_GET_SALES_INFO_Result> dataList1 = _salesRepo.GetSalesInfo(date);
                List<SP_SALES_PERFORMANCE_Result> dataList2 = _salesRepo.GetSalesPerformance(date);
                List<SP_SALES_DATE_AMOUNT_Result> dataList3 = _salesRepo.GetDateWiseSalesInfo(date);
                List<SP_RPT_GET_SALES_INFO_CENTER_Result> dataList4 = _salesRepo.GetSalesInfoCenter(date);
                List<SP_SALES_PERFORMANCE_CENTER_Result> dataList5 = _salesRepo.GetSalesPerformanceCenter(date);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\DailySalesReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DailySalesDS", dataList1));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalePerDS", dataList2));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DateAmountDS", dataList3));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DailySalesCenterDS", dataList4));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesPerformanceCenterDS", dataList5));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        public ActionResult SalesInfo2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalesInfo2(DateTime date)
        {
            string dateParam = date.ToString("dd-MMM-yyyy");
            string financialYearParam = (date.Year - 1).ToString() + " - " + date.Year.ToString();
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            //ReportParameter[] parameters = new ReportParameter[1];


            //parameters[1] = new ReportParameter("FinancialYear", financialYearParam);
            try
            {
                List<sp_GetDealerSalesInfo_Result> dataList1 = _salesRepo.GetDealerSales(date);
                List<sp_GetZoneSalesInfo_Result> dataList2 = _salesRepo.GetZonalSales(date);
                List<sp_GetMonthlyTotalByZone_Result> dataList3 = _salesRepo.GetTotalByZone(date);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\DealerZoneSalesReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DealerDS", dataList1));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ZoneDS", dataList2));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("YearlyDS", dataList3));
                //parameters[0] = new ReportParameter("DateParam", dateParam.ToString());
                //reportViewer.LocalReport.SetParameters(parameters);
                //reportViewer.LocalReport.Refresh();

                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }


        #region Sales 3 and Sales 4 Report

        public ActionResult SalesInfo3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalesInfo3(DateTime date)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);

            try
            {
                List<SP_RPT_GET_DEPOSIT_INFO_Result> dataList1 = _salesRepo.GetDepositSales(date);

                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\SalesDepositReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesDepositDS", dataList1));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }


        public ActionResult SalesInfo4()
        {
            //List<EntityModel> objEntityModel = new List<EntityModel>(); 
            //objEntityModel = _salesRepo.GetALLDealerEntity(); 
            //return View(objEntityModel);
            return View();
        }

        [HttpPost]
        public ActionResult SalesInfo4(DateTime fdate, DateTime tdate, int EID)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);

            try
            {
                List<SP_GET_MODEL_WISE_DATA_Result> dataList1 = _salesRepo.GetDealerModelSales(fdate, tdate, EID);

                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\DailyGroupSalesReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DealerModelSalesDS", dataList1));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        public ActionResult SalesInfo5()
        {
            //List<EntityModel> objEntityModel = new List<EntityModel>(); 
            //objEntityModel = _salesRepo.GetALLDealerEntity(); 
            //return View(objEntityModel);
            return View();
        }

        [HttpPost]
        public ActionResult SalesInfo5(DateTime date)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);

            try
            {
                List<SP_GET_TABLE_OF_CON_ASC_Result> dataList1 = _salesRepo.SP_GET_TABLE_OF_CON_ASC("");
                List<SP_GET_TABLE_OF_CON_DESC_Result> dataList2 = _salesRepo.SP_GET_TABLE_OF_CON_DESC("");
                List<SP_GET_MQ_CS_REPORT_Result> dataList3 = _salesRepo.SP_GET_MQ_CS_REPORT();
                List<SP_SALES_QTY_JULY_Result> dataList4 = _salesRepo.SP_SALES_QTY_JULY();
                List<SP_SALES_QTY_AUG_Result> dataList5 = _salesRepo.SP_SALES_QTY_AUG();
                List<SP_SALES_QTY_SEP_Result> dataList6 = _salesRepo.SP_SALES_QTY_SEP();
                List<SP_SALES_QTY_OCT_Result> dataList7 = _salesRepo.SP_SALES_QTY_OCT();
                List<SP_SALES_QTY_NOV_Result> dataList8 = _salesRepo.SP_SALES_QTY_NOV();
                List<SP_SALES_QTY_DEC_Result> dataList9 = _salesRepo.SP_SALES_QTY_DEC();
                List<SP_SALES_QTY_JAN_Result> dataList10 = _salesRepo.SP_SALES_QTY_JAN();
                List<SP_SALES_QTY_FEB_Result> dataList11 = _salesRepo.SP_SALES_QTY_FEB();
                List<SP_SALES_QTY_MAR_Result> dataList12 = _salesRepo.SP_SALES_QTY_MAR();
                List<SP_SALES_QTY_APR_Result> dataList13 = _salesRepo.SP_SALES_QTY_APR();
                List<SP_SALES_QTY_MAY_Result> dataList14 = _salesRepo.SP_SALES_QTY_MAY();
                List<SP_SALES_QTY_JUN_Result> dataList15 = _salesRepo.SP_SALES_QTY_JUN();

                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\MQReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_TABLE_ASC", dataList1));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_TABLE_DESC", dataList2));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_CLOS_STOCK_DS", dataList3));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_JULY_QTY", dataList4));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_AUG_QTY", dataList5));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_SEP_QTY", dataList6));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_OCT_QTY", dataList7));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_NOV_QTY", dataList8));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_DEC_QTY", dataList9));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_JAN_QTY", dataList10));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_FEB_QTY", dataList11));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_MAR_QTY", dataList12));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_APR_QTY", dataList13));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_MAY_QTY", dataList14));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_JUN_QTY", dataList15));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }


        #endregion Sales 3 and Sales 4 Report


        #region DEALER ACCOUNT INFO 
        public ActionResult ZoneWiseDealerStatement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ZoneWiseDealerStatement(DateTime fdate, DateTime tdate, string zone = "")
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<SP_DEALER_ACCOUNT_INFO_Result> dataList1 = _salesRepo.SP_DEALER_ACCOUNT_INFO(fdate, tdate, Session["UserName"].ToString(), zone, "");

                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ZoneWiseDealerStatement.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DealerStatementDS", dataList1));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        #endregion DEALER ACCOUNT INFO

        #region MQ Report
        public ActionResult MQ_Report()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MQ_Report(string value="")
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<SP_GET_TABLE_OF_CON_ASC_Result> dataList1 = _salesRepo.SP_GET_TABLE_OF_CON_ASC("");
                List<SP_GET_TABLE_OF_CON_DESC_Result> dataList2 = _salesRepo.SP_GET_TABLE_OF_CON_DESC("");
                List<SP_GET_MQ_REPORT_DATA_Result> dataList3 = _salesRepo.SP_GET_MQ_REPORT_DATA();

                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\MQReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_TABLE_ASC", dataList1));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQ_TABLE_DESC", dataList2));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MQReportDS", dataList3));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        #endregion MQ Report

        #region Quantity Sales
        public ActionResult SalesQuantity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalesQuantity(DateTime date)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<sp_DailyProductSalesQuantity_Result> dataList = _salesRepo.GetDailySalesQuantity(date);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ProductSalesQuantityReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsSalesQuantity", dataList));
                ViewBag.ReportViewer = reportViewer;
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        #endregion
    }
}