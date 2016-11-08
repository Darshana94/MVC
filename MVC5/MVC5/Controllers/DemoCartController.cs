using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.Models;

namespace MVC5.Controllers
{
    public class DemoCartController : Controller
    {
        Demo_onlineEntities db = new Demo_onlineEntities();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowProduct()
        {
            return View(db.tb_Product.ToList());
        }
        public ActionResult Add(int id)
        {
            Cart cart= Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            //get infor product
            var itemproduct = db.tb_Product.Where(p => p.ID_Product == id).First();
            cart.
            return RedirectToAction("ShowCart", "DemoCart"); 
        }
    }
}