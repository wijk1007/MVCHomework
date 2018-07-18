using MVCHomework1.Models.ViewModels;
using MVCHomework1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCHomework1.Controllers
{
    public class MoneyController : Controller
    {
        private Model1 db = new Model1();
        
        
        public ActionResult _MoneyList()
        {
            return View(db.AccountBook.OrderByDescending(a => a.Dateee).ToList());
        }       

        // GET: Money
        public ActionResult Money()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Money([Bind(Include = "Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountBook)
        {
            if (accountBook.Categoryyy.ToString() == "-1")
            {
                ModelState.AddModelError("Categoryyy", "請選擇類別");
                return View(accountBook);
            }
                if (accountBook.Dateee != null)
            {
                var date = (DateTime)accountBook.Dateee;
                var now = DateTime.Now;
                if (date > now)
                {
                    ModelState.AddModelError("Dateee", "日期欄位值不可以大於今天的日期");
                    return View(accountBook);
                }
            }
            if (ModelState.IsValid)
            {
               
                if (accountBook.Remarkkk == null)
                {
                    accountBook.Remarkkk = "";
                }
                    var newData = new AccountBook()
                    {
                        Id = Guid.NewGuid(),
                        Categoryyy = accountBook.Categoryyy,
                        Amounttt = accountBook.Amounttt,
                        Dateee= accountBook.Dateee,
                        Remarkkk= accountBook.Remarkkk
                    };
                    db.AccountBook.Add(newData);

                db.SaveChanges();
                return RedirectToAction("Money");
            }

            return View("Money");
        }

    }
}