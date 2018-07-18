using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCHomework1.Models.ViewModels
{
    [Table("AccountBook")]
    public class AccountBook
    {

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "數字形式")]
        public int Categoryyy { get; set; }
      
        [Display(Name = "日期形式")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "請輸入日期")]
        public DateTime Dateee { get; set; }

        [Display(Name = "數字形式")]        
        public int Amounttt { get; set; }
       
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [DisplayName("備註")]
        public string Remarkkk { get; set; }

    }
}