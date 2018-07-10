using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomework1.Models.ViewModels
{
    public class MoneyViewModel
    {
        public int No { get; set; }
        public string Class { get; set; }
        public DateTime Date { get; set; }
        public string Money { get; set; }
    }
}