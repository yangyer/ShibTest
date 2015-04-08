using ShibTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShibTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var homeModel = new HomeModel();

            homeModel.ClientUrl = Request.Url.ToString();
            homeModel.ShibUrl = "https://" + Request.Url.Host + "/Shibboleth.sso";
            homeModel.EntityId = "https://shibtest.ucmerced.edu/idp/shibboleth";

            return View(homeModel);
        }
    }
}