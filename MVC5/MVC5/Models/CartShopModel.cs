using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Models
{
    public class CartShopModel : Controller
    {
        // GET: CartShopModel
        public ActionResult Index()
        {
            return View();
        }
    }
    public class Cart {
        List<cartItem> items = new List<cartItem>();
    }
}