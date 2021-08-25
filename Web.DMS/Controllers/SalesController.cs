using AutoMapper;
using BLL.DMS.Helpers;
using BLL.DMS.Repositories;
using BLL.DMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.DMS.Controllers
{
    [Authorize]
    public class SalesController : Controller
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IStockRepository _stockRepo;
        private readonly ISalesRepository _salesRepo;
        private readonly IEntityRepository _entityRepo;
        private readonly IMapper _mapper;
        public SalesController(ISalesRepository salesRepo,ICustomerRepository customerRepo, IStockRepository stockRepo, IEntityRepository entityRepo)
        {
            _mapper = AutoMapperProfiles.Mapper;
            _salesRepo = salesRepo;
            _customerRepo = customerRepo;
            _stockRepo = stockRepo;
            _entityRepo = entityRepo;
        }
        // GET: Sales
        public ActionResult Index()
        {
            SalesViewModel model = new SalesViewModel();
            try
            {
                if(!String.IsNullOrEmpty(Session["branchCode"].ToString()))
                {
                    model.InvoiceNO = _salesRepo.GetInvoiceNo(Session["branchCode"].ToString());
                }
                model.CustomerModel.CityList = _customerRepo.GetAllCities();
                model.ModelList = LoadProductList();
                model.EntityList = _entityRepo.GetAllEntities();
                model.TermsConditionList = _salesRepo.GetTermsAndConditionsList();
            }
            catch (Exception ex)
            {
                var error = ex.InnerException.Message.ToString();
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SalesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                SalesViewModel newModel = new SalesViewModel();
                if (!String.IsNullOrEmpty(Session["branchCode"].ToString()))
                {
                    newModel.InvoiceNO = _salesRepo.GetInvoiceNo(Session["branchCode"].ToString());
                }
                newModel.CustomerModel.CityList = _customerRepo.GetAllCities();
                newModel.ModelList = LoadProductList();
                newModel.EntityList = _entityRepo.GetAllEntities();
                newModel.TermsConditionList = _salesRepo.GetTermsAndConditionsList();
                return View(newModel);
            }
            
        }
        [HttpPost]
        public JsonResult GetProductInfo(int productId)
        {
            string msg = string.Empty;
            try
            {
                var obj = _salesRepo.GetProductInfoById(productId);
                if (obj != null)
                {
                    return Json(new
                    {
                        ProdDesc = obj.ProdName,
                        UnitPrice = obj.UnitPrice,
                        CampaignPrice = obj.CampaignPrice,
                        ProdModel = obj.Model,
                        ProductId = obj.ProductID
                    });
                }
                else
                {
                    return Json(new { Result = false });
                }
            }
            catch (Exception ex)
            {
                return Json(new { Result = false });
            }
        }
        [HttpPost]
        public JsonResult GetProductInfoByCode(string prodCode)
        {
            string msg = string.Empty;
            try
            {
                var obj = _salesRepo.GetProductInfoByCode(prodCode);
                if (obj != null)
                {
                    return Json(new
                    {
                        ProdDesc = obj.ProdName,
                        UnitPrice = obj.UnitPrice,
                        CampaignPrice = obj.CampaignPrice,
                        ProdModel = obj.Model,
                        ProductId = obj.ProductID.ToString()
                    });
                }
                else
                {
                    return Json(new { Result = false });
                }
            }
            catch (Exception ex)
            {
                return Json(new { Result = false });
            }
        }

        [HttpPost]
        public JsonResult GetCustomerInfo(string mobileNo)
        {
            string msg = string.Empty;
            try
            {
                var obj = _salesRepo.GetCustomerInfo(mobileNo);
                if (obj != null)
                {
                    return Json(new
                    {
                        CustomerName = obj.CustName,
                        CustomerAddress = obj.Address,
                        CustomerEmail = obj.Email
                    });
                }
                else
                {
                    return Json(new { Result = false });
                }
            }
            catch (Exception ex)
            {
                return Json(new { Result = false });
            }
        }
        [HttpPost]
        public JsonResult GetSellerInfo(string entityCode)
        {
            string msg = string.Empty;
            try
            {
                var obj = _salesRepo.GetSellerInfo(entityCode);
                if (obj != null)
                {
                    return Json(new
                    {
                        sellerInfo = obj.ContactPerson + ", " + obj.eName
                    });
                }
                else
                {
                    return Json(new { Result = false });
                }
            }
            catch (Exception ex)
            {
                return Json(new { Result = false });
            }
        }
        public PartialViewResult AddProductDetail(SalesDetailViewModel model)
        {
            var master = new SalesViewModel();
            master.SalesDetailList = new List<SalesDetailViewModel>();
            master.SalesDetailList.Add(model);

            return PartialView("_Detail", master);
        }

        private List<ProductModelGroupViewModel> LoadProductList()
        {
            List<ProductModelGroupViewModel> grouplist = _stockRepo.GetProductModelName();
            ProductModelGroupViewModel newItem = new ProductModelGroupViewModel
            {
                ModelName = "--Select--",
                ProductId = 0
            };
            grouplist.Insert(0, newItem);

            return grouplist;
        }

    }
}