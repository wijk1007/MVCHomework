using MVCHomework1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomework1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Money()
        {
            return View();
        }
        public ActionResult _MoneyList()
        {
            var model = new List<MoneyViewModel>();
            var classtext = "";
            for (int i = 0; i < 50; i++)
            {
                if (i % 5 == 0)
                {
                    classtext = "收入";
                }
                else
                {
                    classtext = "支出";
                }
                model.Add(new MoneyViewModel { No = i + 1, Class = classtext, Date = new System.DateTime(2018, 6, 1).AddDays(+i), Money = ((i + 1) * 100).ToString("#,#", CultureInfo.InvariantCulture) });
            }
            return View(model);
        }
    }
}