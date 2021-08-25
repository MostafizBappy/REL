using AutoMapper;
using BLL.DMS.Helpers;
using BLL.DMS.Repositories;
using BLL.DMS.ViewModel;
using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Web.DMS.Controllers
{
    [Authorize]
    public class EntitiesController : Controller
    {
        private readonly IEntityRepository _entityRepo;
        private readonly IMapper _mapper;

        // GET: Entities
        public EntitiesController(IEntityRepository entityRepo)
        {
            _mapper = AutoMapperProfiles.Mapper;
            _entityRepo = entityRepo;
        }
        public ActionResult Index()
        {
            var dbList = _entityRepo.GetAllEntities();
            List<EntityViewModel> entityList = _mapper.Map<List<EntityViewModel>>(dbList);
            return View(entityList);
        }

        // GET: Entities/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entity entity = _entityRepo.GetById(Convert.ToInt32(id));
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // GET: Entities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EID,SerialNo,eName,eNameBangla,EDesc,EDescBangla,EntityType,ParentEntity,Showroomtype,CommissionGet,SalesOrShowroom,ActiveDeactive,GroupSL,UserID,PCName,EntryDate,sFlag,EnableSalesSheet,SecurityMoney,DepositedUpTo0809,EntityCode,NoTr,DP_Inactive,ContactPerson,Desg,Status,ContactNo,InDhk,ZoneID,PhoneNo,EmailAdd,CorporateSale,iTagStock,SalesCenterType,MapLink,pEID,ReqMailTo")] Entity entity)
        {
            if (ModelState.IsValid)
            {
                _entityRepo.Add(entity);
                _entityRepo.SaveAll();
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        // GET: Entities/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entity entity = _entityRepo.GetById(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // POST: Entities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EID,SerialNo,eName,eNameBangla,EDesc,EDescBangla,EntityType,ParentEntity,Showroomtype,CommissionGet,SalesOrShowroom,ActiveDeactive,GroupSL,UserID,PCName,EntryDate,sFlag,EnableSalesSheet,SecurityMoney,DepositedUpTo0809,EntityCode,NoTr,DP_Inactive,ContactPerson,Desg,Status,ContactNo,InDhk,ZoneID,PhoneNo,EmailAdd,CorporateSale,iTagStock,SalesCenterType,MapLink,pEID,ReqMailTo")] Entity entity)
        {
            if (ModelState.IsValid)
            {
                _entityRepo.UpdateEntity(entity);
                return RedirectToAction("Index");
            }
            return View(entity);
        }

        // GET: Entities/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Entity entity = _entityRepo.GetById(id);
        //    if (entity == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(entity);
        //}

        // POST: Entities/Delete/5
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Entity entity = _entityRepo.GetById(Convert.ToInt32(id));
            _entityRepo.Delete(entity);
            _entityRepo.SaveAll();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
