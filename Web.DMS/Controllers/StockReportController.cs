using BLL.DMS.Repositories;
using BLL.DMS.ViewModel;
using DAL.DMS;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Web.DMS.Controllers
{
    [Authorize]
    public class StockReportController : Controller
    {
        // GET: StockReport
        private readonly IStockRepository _stockRepo;
        private readonly IEntityRepository _entityRepo;
        public StockReportController(IStockRepository stockRepo, IEntityRepository entityRepo)
        {
            _stockRepo = stockRepo;
            _entityRepo = entityRepo;
        }
        public ActionResult EntityWiseStock()
        {
            ViewBag.Entities = _entityRepo.GetAllEntities();
            ViewBag.Groups = LoadProductGroupList();
            return View();
        }
        [HttpPost]
        public ActionResult EntityWiseStock(DateTime date, int entityId = 0, string groupName = "All")
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<sp_EntityDateWiseStock_Result> dataList = _stockRepo.GetEntityDateWiseStock(date, entityId, groupName);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\EntityWiseStock.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsEntityStock", dataList));
                ViewBag.ReportViewer = reportViewer;
                ViewBag.Entities = _entityRepo.GetAllEntities();
                ViewBag.Groups = LoadProductGroupList();
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        public ActionResult GroupWiseOpeningStock()
        {
            ViewBag.Groups = LoadProductGroupList();
            return View();
        }

        [HttpPost]
        public ActionResult GroupWiseOpeningStock(DateTime date, string groupName)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<sp_GroupWiseOpeningStock_Result> dataList = _stockRepo.GetGroupWiseOpeningStock(date, groupName);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\GroupWiseOS.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsGroupeWiseStock", dataList));
                ViewBag.ReportViewer = reportViewer;
                ViewBag.Groups = LoadProductGroupList();
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        public ActionResult GroupWiseOpeningStockSummary()
        {
            ViewBag.Groups = LoadProductGroupList();
            return View();
        }

        [HttpPost]
        public ActionResult GroupWiseOpeningStockSummary(DateTime date, string groupName = "")
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                List<sp_GroupWiseOpeningStock_Result> dataList = _stockRepo.GetGroupWiseOpeningStock(date, groupName);
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\GroupWiseOSSummary.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsGroupeWiseStock", dataList));
                ViewBag.ReportViewer = reportViewer;
                ViewBag.Groups = LoadProductGroupList();
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        private List<ProductModelGroupViewModel> LoadProductGroupList()
        {
            List<ProductModelGroupViewModel> grouplist = _stockRepo.GetProductGroupName();
            ProductModelGroupViewModel newItem = new ProductModelGroupViewModel { 
                GroupName = "All"
            };
            grouplist.Insert(0, newItem);

            return grouplist;
        }

        private List<Entity> LoadEntityList()
        {
            List<Entity> entityList = _entityRepo.GetAllEntities();
            Entity newItem = new Entity
            {
                eName = "All",
                EID = 0
            };
            entityList.Insert(0, newItem);

            return entityList;
        }
    }
}