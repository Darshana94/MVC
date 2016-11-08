using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        protected CodeDB D = new CodeDB();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken ]
        public ActionResult SaveDataStudent(StudentModel f)
        {
            if (ModelState.IsValid)
            {
                D.Open();
                int i = D.DataInsert("INSERT INTO tblproduct(productname,quantity,price)VALUES('" + f.productname + "','" + f.quantity + "','" + f.price + "',)");
                if (i > 0)
                {
                    ModelState.AddModelError("Success", "Save Success");
                }
                else
                {
                    ModelState.AddModelError("Error", "Save Error");
                }
                D.Close();
            }
            return RedirectToAction("Index","Student");
        }
    }
}