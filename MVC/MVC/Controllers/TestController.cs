using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        public CodeDB DB = new CodeDB();


        public ActionResult Index()
        {
            bool i = DB.Close();
            if (i = true)
            {
                return Content(i.ToString());
            }
            else
            {
                return Content(i.ToString());
            }
            return View();
        }
    }
}