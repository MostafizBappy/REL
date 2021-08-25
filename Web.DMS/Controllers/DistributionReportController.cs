using BLL.DMS.Repositories;
using BLL.DMS.ViewModel;
using DAL.DMS;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace Web.DMS.Controllers
{
    [Authorize]
    public class DistributionReportController : Controller
    {
        private readonly IStockRepository _stockRepo;
        public DistributionReportController(IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
        }
        // GET: DistributionReport
        public ActionResult ShowroomModelWiseDistributionPlan()
        {
            ViewBag.Groups = _stockRepo.GetProductGroupName();
            return View();
        }

        [HttpPost]
        public ActionResult ShowroomModelWiseDistributionPlan(DateTime date, string groupName, string modelName)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                //0 for only showroom 
                List<sp_GroupWiseDistributionPlan_Result> dataList = _stockRepo.GetShowroomModelWiseDistributionPlan(date, groupName, 0);
                if(!String.IsNullOrEmpty(modelName))
                {
                    dataList = dataList.Where(x => x.Model == modelName).ToList();
                }
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ShowroomDistributionPlanReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsShowroomDP", dataList));
                ViewBag.ReportViewer = reportViewer;
                ViewBag.Groups = _stockRepo.GetProductGroupName();
            }
            catch (Exception ex)
            {

                throw;
            }


            return View();
        }

        public ActionResult ZoneModelWiseDistributionPlan()
        {
            ViewBag.Groups = _stockRepo.GetProductGroupName();
            return View();
        }

        [HttpPost]
        public ActionResult ZoneModelWiseDistributionPlan(DateTime date, string groupName, string modelName)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(100);
            reportViewer.Height = Unit.Percentage(100);
            try
            {
                //1 for with dealer/zone 
                List<sp_GroupWiseDistributionPlan_Result> dataList = _stockRepo.GetShowroomModelWiseDistributionPlan(date, groupName, 1);
                if (!String.IsNullOrEmpty(modelName))
                {
                    dataList = dataList.Where(x => x.Model == modelName).ToList();
                }
                reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ZoneDistributionPlanReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsShowroomDP", dataList));
                ViewBag.ReportViewer = reportViewer;
                ViewBag.Groups = _stockRepo.GetProductGroupName();
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
            ProductModelGroupViewModel newItem = new ProductModelGroupViewModel
            {
                GroupName = "All"
            };
            grouplist.Insert(0, newItem);

            return grouplist;
        }

        public string GetModelList(string groupName)
        {
            var listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem { Text = "[Select One]", Value = "" });
            var items = new List<ProductModelGroupViewModel>();

            items = _stockRepo.GetProductModelName().Where(x => x.GroupName == groupName).ToList();

            if (items != null)
            {
                foreach (var item in items)
                {
                    var listItem = new SelectListItem { Text = item.ModelName, Value = item.ModelName};
                    listItems.Add(listItem);
                }
            }

            return new JavaScriptSerializer().Serialize(listItems);
        }
    }
}