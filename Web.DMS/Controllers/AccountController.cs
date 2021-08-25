using BLL.DMS.Repositories;
using BLL.DMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Web.DMS.Models;
using System.Web.Security;
using DAL.DMS;

namespace Web.DMS.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accRepo;
        public AccountController(IAccountRepository accRepo)
        {
            _accRepo = accRepo;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginModels _login)
        {
            if (ModelState.IsValid) //validating the user inputs
            {
                bool isExist = false;
                using (dbCIDEntities _entity = new dbCIDEntities())  // out Entity name is "SampleMenuMasterDBEntites"
                {
                    isExist = _entity.SoftUsers.Where(x => x.UserName.Trim().ToLower() == _login.UserName.Trim().ToLower()
                    &&  x.Passward.Trim().ToLower() == _login.Password.Trim().ToLower()).Any(); //validating the user name in tblLogin table whether the user name is exist or not
                    if (isExist)
                    {
                        LoginModels _loginCredentials = _entity.SoftUsers.Where(x => x.UserName.Trim().ToLower() == _login.UserName.Trim().ToLower()).Select(x => new LoginModels
                        {
                            UserName = x.UserName,
                            UserRoleId = x.RolesId,
                            UserId = x.ID,
                            BranchCode = x.BranchCode
                        }).FirstOrDefault();  // Get the login user details and bind it to LoginModels class
                        List<MenuModels> _menus = _entity.tblSubMenus.Where(x => x.RoleId == _loginCredentials.UserRoleId).Select(x => new MenuModels
                        {
                            MainMenuId = x.tblMainMenu.Id,
                            MainMenuName = x.tblMainMenu.MainMenu,
                            SubMenuId = x.Id,
                            SubMenuName = x.SubMenu,
                            ControllerName = x.Controller,
                            ActionName = x.Action,
                            RoleId = x.RoleId
                        }).OrderBy(x=>x.MainMenuId).ToList(); //Get the Menu details from entity and bind it in MenuModels list.
                        FormsAuthentication.SetAuthCookie(_loginCredentials.UserName, false); // set the formauthentication cookie
                        Session["LoginCredentials"] = _loginCredentials; // Bind the _logincredentials details to "LoginCredentials" session
                        Session["MenuMaster"] = _menus; //Bind the _menus list to MenuMaster session
                        Session["UserName"] = _loginCredentials.UserName;
                        Session["branchCode"] = _loginCredentials.BranchCode;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.ErrorMsg = "Please enter the valid credentials!...";
                        return View();
                    }
                }
            }
            return View();
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            return RedirectToAction("Login", "Account");
        }
    }
}