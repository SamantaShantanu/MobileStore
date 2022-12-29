using MobileStore.BLL.CacheOperations;
using MobileStore.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        private ICacheOperations _cacheOperations;
        public HomeController(ICacheOperations cacheOperations)
        {
            _cacheOperations = cacheOperations;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration(UserRegistration er)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                else
                {
                    if(_cacheOperations.RegisterUser(er))
                    {
                        ViewBag.Name = "Success";
                        return View("~/Views/Home/SuccessErrorMessage.cshtml");
                    }
                    else
                    {
                        ViewBag.Name = "NotSuccess";
                        return View("~/Views/Home/SuccessErrorMessage.cshtml");
                    }

                }
            }
            catch(Exception ex)
            {
                ViewBag.Name = "Error";
                return View("~/Views/Home/SuccessErrorMessage.cshtml");
            }
            
        }
        public ActionResult Login(UserRegistration er)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            else
            {

            }
            return View();
        }
    }
}