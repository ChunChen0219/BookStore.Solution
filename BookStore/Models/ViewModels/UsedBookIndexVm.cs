using BookStore.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.ViewModels
{
    public class UsedBookIndexVm
    {
        public int Id { get; set; }

        [Display(Name = "會員Email")]
        public string MemberEmail { get; set; }

        [Display(Name = "書籍分類")]
        public string CategoryName { get; set; }

        [Display(Name = "上架狀態")]
        public bool ProductStatus { get; set; }

        [Display(Name = "販賣價格")]
        public decimal Price { get; set; }
        
        public string ISBN { get; set; }

        [Display(Name = "書況")]
        public string BookStatus { get; set; }

    }
}